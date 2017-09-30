Function Invoke-SampleLibraryReference {
    Clear-Host
    $LibraryProjectName = 'GeoCoordinates'
    $ConsoleProgramProjectName = 'GeoCoordinateProgram'
    $expression = @"
dotnet new console --output $ConsoleProgramProjectName
dotnet new Library --output $LibraryProjectName
Remove-Item .\$LibraryProjectName\class1.cs 
'namespace GeoCoordinates' > .\$LibraryProjectName\GeoTypes.cs
Get-Content $PSScriptRoot\Listing09.12.MakingTypesAvailableExternally.cs | 
    Select-Object -Skip 1  >> .\$LibraryProjectName\GeoTypes.cs
dotnet add .\$ConsoleProgramProjectName\$ConsoleProgramProjectName.csproj reference .\$LibraryProjectName\$LibraryProjectName.csproj
"@ -split '`n'
    $expression += @"
@'
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
'@ > .\$ConsoleProgramProjectName\Program.cs
"@

    $expression +=
@"
dotnet run -p .\$ConsoleProgramProjectName\$ConsoleProgramProjectName.csproj
"@ -split '`n'

    $expression | ForEach-Object{
        Write-Host ">$_" -ForegroundColor Yellow;
        Invoke-Expression $_ }
}
Get-Item .\$LibraryProjectName,.\$ConsoleProgramProjectName |
    Remove-Item  -Recurse
Invoke-SampleLibraryReference