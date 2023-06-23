using System.Security.Cryptography;

namespace MSUYamlValidator;

public class MSUTrackConfig
{
    public string? Name { get; set; }
    public string? Artist { get; set; }
    public string? Album { get; set; }
    public long? FileLength { get; set; }
    public string? Hash { get; set; }
    public string? Path { get; set; }
    public ICollection<MSUTrackConfig>? Alts { get; set; }

    public bool HasData => !string.IsNullOrWhiteSpace(Name) || !string.IsNullOrWhiteSpace(Artist) || !string.IsNullOrWhiteSpace(Album);

    public bool HasAltTrackData =>
        !string.IsNullOrWhiteSpace(Path) && !string.IsNullOrWhiteSpace(Hash) && FileLength > 0;

    public string GetDisplayText(string? parentArtist, string? parentAlbum)
    {
        var artist = Artist != null ? $" by {Artist}" : parentArtist != null ? $" by {parentArtist}" : "";
        var album = Album != null ? $" from album {Album}" : parentAlbum != null ? $" from album {parentAlbum}" : "";;
        return $"{Name}{artist}{album}";
    }

    public string? DeterminePath(string path1, string path2)
    {
        var path1Exists = !string.IsNullOrWhiteSpace(path1) && File.Exists(path1);
        var path2Exists = !string.IsNullOrWhiteSpace(path2) && File.Exists(path2);
        var path1Length = path1Exists ? new FileInfo(path1).Length : 0;
        var path2Length = path2Exists ? new FileInfo(path2).Length : 0;

        if (path1Length == FileLength && path2Length == FileLength)
        {
            using var sha1 = SHA1.Create();
            using var stream1 = File.OpenRead(path1);
            using var stream2 = File.OpenRead(path2);
            var hash1 = BitConverter.ToString(sha1.ComputeHash(stream1)).Replace("-", "");
            var hash2 = BitConverter.ToString(sha1.ComputeHash(stream2)).Replace("-", "");
            if (hash1 == Hash)
            {
                return path1;
            }
            else if (hash2 == Hash)
            {
                return hash2;
            }
        }
        else if (path1Length == FileLength)
        {
            return path1;
        }
        else if (path2Length == FileLength)
        {
            return path2;
        }

        return null;
    }
}