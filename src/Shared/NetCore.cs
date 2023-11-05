using System.Reflection;

namespace AddisonWesley.Michaelis.EssentialCSharp.Shared;

public static class NetCore
{
    private static readonly char[] separator = new[] { '/', '\\' };

    public static string GetNetCoreVersion()
    {
        Assembly assembly = typeof(System.Runtime.GCSettings).GetTypeInfo().Assembly;
        string[] assemblyPath = assembly.Location!.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        int netCoreAppIndex = Array.IndexOf(assemblyPath, "Microsoft.NETCore.App");
        return netCoreAppIndex > 0 && netCoreAppIndex < assemblyPath.Length - 2
            ? assemblyPath[netCoreAppIndex + 1]
            : throw new Exception("Unable to determine .NET Core version.");
    }

    public static string GetCurrentNETPreprocessorSymbol()
    {
        return $"NET{Environment.Version.Major}_{Environment.Version.Minor}_OR_GREATER";
    }
}
