namespace MSUYamlValidator;

public class MSUConfig
{
    public string? PackName { get; set; }
    public string? PackAuthor { get; set; }
    public int PackVersion { get; set; }
    public string? Artist { get; set; }
    public string? Album { get; set; }
    public MSUTrackList? Tracks { get; set; }
}