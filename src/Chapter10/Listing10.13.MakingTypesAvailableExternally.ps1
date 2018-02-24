[CmdletBinding()]
param(
    [int]$traceLevel
)
if($traceLevel -notin $PSBoundParameters.Keys) {
    $traceLevel = Read-Host -Prompt @"
    Specifiy the trace level:
    - 0: Turn script tracing off.
    - 1: Trace script lines as they run.
    - 2: Trace script lines, variable assignments, function calls, and scripts.

"@ 
}

$LibraryProjectName = 'GeoCoordinates'
$ConsoleProgramProjectName = 'GeoCoordinateProgram'

try {
    Get-Item .\$LibraryProjectName,.\$ConsoleProgramProjectName -ErrorAction Ignore | Remove-Item  -Recurse
    Set-PSDebug -Trace $traceLevel
    dotnet new console --output $ConsoleProgramProjectName
    dotnet new Library --output $LibraryProjectName
    Remove-Item .\$LibraryProjectName\class1.cs 
    $codeListing = 
        @('namespace GeoCoordinates') + (
        Get-Content $PSScriptRoot\Listing09.12.MakingTypesAvailableExternally.cs | 
        Select-Object -Skip 1)  >> .\$LibraryProjectName\GeoTypes.cs
    Get-Content .\$LibraryProjectName\GeoTypes.cs
    dotnet add .\$ConsoleProgramProjectName\$ConsoleProgramProjectName.csproj reference .\$LibraryProjectName\$LibraryProjectName.csproj
    $codeListing = @"
namespace $ConsoleProgramProjectName
{
    using $LibraryProjectName;
    class HelloWorld
    {
        static void Main()
        {
            System.Type coordinateType = (new Coordinate()).GetType();
            System.Console.WriteLine(
                    $@"{coordinateType.Assembly} {System.Environment.NewLine
                    }path='{coordinateType.Assembly.Location}'"
                );
        }
    }
}
"@ 
    $codeListing > .\$ConsoleProgramProjectName\Program.cs
    Get-Content .\$ConsoleProgramProjectName\Program.cs
    dotnet run -p .\$ConsoleProgramProjectName\$ConsoleProgramProjectName.csproj

}
finally {
    Set-PSDebug -Off
}