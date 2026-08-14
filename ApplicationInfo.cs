public class ApplicationInfo
{
    public string Path { get; }
    public string? Arguments { get; }

    public ApplicationInfo(string path, string? arguments)
    {
        Path = path;
        Arguments = arguments;
    }
}
