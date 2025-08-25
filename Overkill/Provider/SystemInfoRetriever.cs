namespace Overkill.Provider;

public static class SystemInfoRetriever
{
    private static string GetSoftwareArchitecture() =>
        Environment.Is64BitOperatingSystem ? "x64" : "x86";

    private static string GetAbsolutePath(Environment.SpecialFolder folder) =>
        Environment.GetFolderPath(folder);

    public static string GetSystemInformation()
    {
        return $"""
                Machine Name: {Environment.MachineName}
                Operating System: {Environment.OSVersion}
                Software Architecture : {GetSoftwareArchitecture()}
                Current User: {Environment.UserName}
                Processor Count: {Environment.ProcessorCount}
                Desktop Directory: {GetAbsolutePath(Environment.SpecialFolder.Desktop)}
                Documents Directory: {GetAbsolutePath(Environment.SpecialFolder.MyDocuments)}
                """;
    }
}