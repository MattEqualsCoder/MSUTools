// See https://aka.ms/new-console-template for more information

using System.Reflection;
using MSUYamlValidator;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

var path = @"";
if (args.Length > 0)
{
    path = args[0];
}

if (string.IsNullOrWhiteSpace(path))
{
    Console.Write("Enter path to YAML file path: ");
    path = Console.ReadLine()?.Replace("\"", "");
}

if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
{
    ExitMessage("Please enter a valid YAML file path");
    return;
}

var text = GetYamlFileText();
if (string.IsNullOrWhiteSpace(text))
{
    ExitMessage("Yaml file is empty");
    return;
}

var config = ParseYamlConfig(text);
if (config == null)
{
    ExitMessage("Invalid YAML file");
    return;
}

List<string> warnings = new List<string>();
List<string> missingTracks = new List<string>();

Console.WriteLine($"Parsing {Path.GetFullPath(path)} successful");
Console.WriteLine();
Console.WriteLine("----------------------------------------------------------------------------------------------------");
Console.WriteLine();
Console.WriteLine($"Tracks for MSU {config.PackName} (v{config.PackVersion}) by {config.PackAuthor}:");
Console.WriteLine();

var directory = Directory.GetParent(path)?.FullName ?? "";
var baseFileName = Path.GetFullPath(path).Replace(".yaml", "").Replace(".yml", "");
var msuPath = baseFileName + ".msu";
var msuFound = File.Exists(msuPath);
var metroidFirst = false;
if (!msuFound)
{
    warnings.Add($"MSU {msuPath} not found");
}
else
{
    var hasTrack41 = File.Exists(baseFileName +  "-41.pcm");
    var hasTrack141 = File.Exists(baseFileName + "-141.pcm");
    var track33Loops = DoesPCMLoop(baseFileName +"-33.pcm");
    var track130Loops = DoesPCMLoop(baseFileName +"-130.pcm");
    
    // Swap if we see the Skull Woods theme above 100
    if (hasTrack141)
    {
        metroidFirst = true;
    }
    // Swap if we see don't see Skull Woods theme below 100 and if either the Z3 epilogue or SM credits themes are incorrectly set to loop
    else if (!hasTrack41 && (track33Loops || track130Loops))
    {
        metroidFirst = true;
    }
}

foreach (var prop in typeof(MSUTrackList).GetProperties())
{
    var track = prop.GetValue(config.Tracks) as MSUTrackConfig;
    if (track == null)
    {
        track = new MSUTrackConfig();
    }
    
    var attribute = prop.GetCustomAttributes<TrackNumberAttribute>().First();
    
    if (!track.HasData)
    {
        missingTracks.Add(prop.Name);
        continue;
    }

    if (msuFound)
    {
        Console.WriteLine(prop.Name);
        
        var trackNumber = metroidFirst ? attribute.MetroidFirst : attribute.ZeldaFirst;
        var basePcmPath = $"{baseFileName}-{trackNumber}.pcm";
        
        if (track.Alts == null || track.Alts.Count == 0)
        {
            var file = Path.GetRelativePath(directory, basePcmPath);
            var pcmFound = File.Exists(basePcmPath);
            var output =
                $"{track.GetDisplayText(config.Artist, config.Album)} {(pcmFound ? "found" : "not found")} at file: {file}";
            Console.WriteLine($" - {output}");
            if (!pcmFound)
            {
                warnings.Add($"{prop.Name}: {output}");
            }
        }
        else
        {
            var tracks = track.Alts.Append(track);
            foreach (var currentTrack in tracks)
            {
                if (!currentTrack.HasData)
                {
                    var output = $"A track for {prop.Name} missing data";
                    Console.WriteLine($" - {output}");
                    warnings.Add($"{prop.Name}: {output}");
                    continue;
                }
                
                if (!currentTrack.HasAltTrackData)
                {
                    var output = $"{currentTrack.GetDisplayText(config.Artist, config.Album)} missing either path, hash, or file_length if alts are desired";
                    Console.WriteLine($" - {output}");
                    warnings.Add($"{prop.Name}: {output}");
                    continue;
                }

                var altFile = Path.Combine(directory, currentTrack.Path!);
                var selectedFile = currentTrack.DeterminePath(basePcmPath, altFile);
                if (selectedFile == null)
                {
                    var file = Path.GetRelativePath(directory, altFile);
                    var output = $"{currentTrack.GetDisplayText(config.Artist, config.Album)} not found at file: {file}";
                    Console.WriteLine($" - {output}");
                    warnings.Add($"{prop.Name}: {output}");
                }
                else
                {
                    var file = Path.GetRelativePath(directory, selectedFile);
                    var output = $"{currentTrack.GetDisplayText(config.Artist, config.Album)} found at file: {file}";
                    Console.WriteLine($" - {output}");
                }
            }
        }
    }
    else
    {
        Console.WriteLine(prop.Name);
        if (track.Alts == null || track.Alts.Count == 0)
        {
            Console.WriteLine($" - {track.GetDisplayText(config.Artist, config.Album)}");
        }
        else
        {
            var tracks = track.Alts.Append(track);
            foreach (var currentTrack in tracks)
            {
                if (!currentTrack.HasData)
                {
                    var output = $"A track for {prop.Name} missing data";
                    Console.WriteLine($" - {output}");
                    warnings.Add($"{prop.Name}: {output}");
                    continue;
                }
                
                if (!currentTrack.HasAltTrackData)
                {
                    var output = $"{currentTrack.GetDisplayText(config.Artist, config.Album)} missing either path, hash, or file_length if alts are desired";
                    Console.WriteLine($" - {output}");
                    warnings.Add($"{prop.Name}: {output}");
                    continue;
                }

                Console.WriteLine($" - {currentTrack.GetDisplayText(config.Artist, config.Album)}");
            }
        }
    }
    
    Console.WriteLine();
}

if (missingTracks.Any())
{
    Console.WriteLine("----------------------------------------------------------------------------------------------------");
    Console.WriteLine();
    Console.WriteLine("Missing Tracks:");
    foreach (var track in missingTracks)
    {
        Console.WriteLine(" - " + track);
    }
    Console.WriteLine();
}

if (warnings.Any())
{
    Console.WriteLine("----------------------------------------------------------------------------------------------------");
    Console.WriteLine();
    Console.WriteLine("Warnings:");
    foreach (var warning in warnings)
    {
        Console.WriteLine(" - " + warning);
    }
    Console.WriteLine();
}


Console.WriteLine("----------------------------------------------------------------------------------------------------");
Console.WriteLine();
Console.WriteLine($"Complete{(warnings.Any() ? " (with Warnings)" : "")}!");
Console.Read();

    
MSUConfig? ParseYamlConfig(string yamlText)
{
    try
    {
        var deserializer = new DeserializerBuilder()
            .WithNamingConvention(UnderscoredNamingConvention.Instance)
            .Build();
        return deserializer.Deserialize<MSUConfig>(yamlText);
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        return null;
    }
}
    
string GetYamlFileText()
{
    using var fileStream = new FileStream(path!, FileMode.Open);
    using var reader = new StreamReader(fileStream);
    return reader.ReadToEnd();
}

void ExitMessage(string message)
{
    Console.WriteLine(message);
    Console.Write("Press any key to exit: ");
    Console.Read();
}

static bool DoesPCMLoop(string fileName)
{
    if (!File.Exists(fileName))
    {
        return false;
    }
    using var fileStream = File.OpenRead(fileName);
    fileStream.Seek(4, SeekOrigin.Begin);
    var bytes = new byte[4];
    fileStream.Read(bytes, 0, 4);
    return bytes.Any(x => x != 0);
}