using System.Text.Json;

class ApplicationRegistry
{
    private Dictionary<string, ApplicationInfo> applications =
        new Dictionary<string, ApplicationInfo>();

    public ApplicationRegistry()
    {
        string json = File.ReadAllText("applications.json");

        applications =
            JsonSerializer.Deserialize<Dictionary<string, ApplicationInfo>>(json)
            ?? new Dictionary<string, ApplicationInfo>();
    }

    public ApplicationInfo? GetApplication(string applicationName)
    {
        if (applications.TryGetValue(applicationName, out ApplicationInfo? applicationInfo))
        {
            return applicationInfo;
        }
        return null;
    }
}
