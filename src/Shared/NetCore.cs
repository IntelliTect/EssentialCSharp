using System.Reflection;

namespace AddisonWesley.Michaelis.EssentialCSharp.Shared;

public static class NetCore
{
    private static readonly char[] _Separators = new[] { '/', '\\' };

    public static string GetNetCoreVersion()
    {
        Assembly assembly = typeof(System.Runtime.GCSettings).GetTypeInfo().Assembly;
        string[] assemblyPath = assembly.Location!.Split(_Separators, StringSplitOptions.RemoveEmptyEntries);
        int netCoreAppIndex = Array.IndexOf(assemblyPath, "Microsoft.NETCore.App");
        return netCoreAppIndex > 0 && netCoreAppIndex < assemblyPath.Length - 2
            ? assemblyPath[netCoreAppIndex + 1]
            : throw new InvalidOperationException("Unable to determine .NET Core version.");
    }

    public static string GetCurrentNETPreprocessorSymbol()
    {
        return $"NET{Environment.Version.Major}_{Environment.Version.Minor}_OR_GREATER";
    }

    public static IEnumerable<string> GetAllValidNETPreprocessorSymbols()
    {
        Version version = Environment.Version;
        return GetAllValidNETPreprocessorSymbols(version.Major, version.Minor);
    }

    public static IEnumerable<string> GetAllValidNETPreprocessorSymbols(int majorVersion, int minorVersion)
    {
        // TODO: Handle minor versions better
        // TODO: Handle versions that aren't NET 5.0 or later
        yield return $"NET{majorVersion}_{minorVersion}";

        // before net 5.0, precompile symbol is NETCOREAPP
        for (int i = 5; i <= majorVersion; i++)
        {
            yield return $"NET{i}_0_OR_GREATER";
        }

        // ex: NETCOREAPP3_1_OR_GREATER
        for (int i = 1; i < 4; i++)
        {
            for (int j = 0; j <= 1; j++)
            {
                yield return $"NETCOREAPP{i}_{j}_OR_GREATER";
            }
        }
    }
}
