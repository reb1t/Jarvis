class ApplicationRegistry
{
    private Dictionary<string, ApplicationInfo> applications =
        new Dictionary<string, ApplicationInfo>();

    public ApplicationRegistry()
    {
        applications.Add(
            "steam",
            new ApplicationInfo("C:\\Program Files (x86)\\Steam\\steam.exe", null)
        );
        applications.Add(
            "zen",
            new ApplicationInfo("C:\\Program Files\\Zen Browser\\zen.exe", null)
        );
        applications.Add(
            "discord",
            new ApplicationInfo(
                "C:\\Users\\reb1t\\AppData\\Local\\Discord\\Update.exe",
                "--processStart Discord.exe"
            )
        );
        applications.Add(
            "telegram",
            new ApplicationInfo(
                "C:\\Users\\reb1t\\AppData\\Roaming\\Telegram Desktop\\Telegram.exe",
                null
            )
        );
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
