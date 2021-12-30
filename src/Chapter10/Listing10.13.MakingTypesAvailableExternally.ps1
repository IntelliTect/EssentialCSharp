[CmdletBinding()]
param(
    [int]$traceLevel
)

if('traceLevel' -notin $PSBoundParameters.Keys) {
    $traceLevel = Read-Host -Prompt @"
    Specifiy the trace level:
    - 0: Turn script tracing off.
    - 1: Trace script lines as they run.
    - 2: Trace script lines, variable assignments, function calls, and scripts.

"@ 
}

[string]$LibraryProjectName = 'GeoCoordinates'
[string]$ConsoleProgramProjectName = 'GeoCoordinateProgram'

[xml]$directoryBuildPropsXml = ([xml](Get-Content "$PSScriptRoot/../../Directory.Build.props"))
[string]$langVersion = $directoryBuildPropsXml.Project.PropertyGroup.LangVersion
# [string[]]$frameworks = $directoryBuildPropsXml.Project.PropertyGroup.TargetFrameworks -split ';'
[string]$SutCSFile = split-path -leaf $MyInvocation.MyCommand.Definition
[string]$SutCSFile = "$PSScriptRoot/$([IO.Path]::GetFileNameWithoutExtension($SutCSFile)).cs"
if(-not (Test-Path $SutCSFile)) { throw "Unable to find the file with the type to export ('$SutCSFile')"}

try {
    Get-Item "$PSScriptRoot/$LibraryProjectName","$PSScriptRoot/$ConsoleProgramProjectName" -ErrorAction Ignore | Remove-Item  -Recurse
    Set-PSDebug -Trace $traceLevel
    
    if([string]::IsNullOrEmpty($langVersion))
    {
        throw "LangVersion not set."
    }

    # Specyfing langVersion as dotnet new appears to ignore the Directory.Build.props file.
    dotnet new Console --langVersion $langVersion --output "$ConsoleProgramProjectName"
    $projectFilePath = "$PSScriptRoot/$ConsoleProgramProjectName/$($ConsoleProgramProjectName).csproj"
    $updatedContent =(Get-Content $projectFilePath) | ? { $_ -notlike '*TargetFramework*'} 
    Set-Content -Value $updatedContent -Path $projectFilePath

    dotnet new ClassLib  --langVersion $langVersion --output "$LibraryProjectName"
    $projectFilePath = "$PSScriptRoot/$LibraryProjectName/$($LibraryProjectName).csproj"
    $updatedContent =(Get-Content $projectFilePath) | ? { $_ -notlike '*TargetFramework*'} 
    Set-Content -Value $updatedContent -Path $projectFilePath
    Remove-Item "$PSScriptRoot/$LibraryProjectName/class1.cs"

    #New-Item -ItemType Directory "$PSScriptRoot/$LibraryProjectName"
    $codeListing = @('namespace GeoCoordinates') + (
        Get-Content $SutCSFile | 
            Select-Object -Skip 1)
    $codeListing > "$PSScriptRoot/$LibraryProjectName/GeoTypes.cs"
    Get-Content "$PSScriptRoot/$LibraryProjectName/GeoTypes.cs"  # Display the listing
    dotnet add "$PSScriptRoot/$ConsoleProgramProjectName/$ConsoleProgramProjectName.csproj" `
        reference "$PSScriptRoot/$LibraryProjectName/$LibraryProjectName.csproj"
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
    $codeListing > "$PSScriptRoot/$ConsoleProgramProjectName/Program.cs"
    Get-Content "$PSScriptRoot/$ConsoleProgramProjectName/Program.cs" # Display the listing
    
    dotnet build "$PSScriptRoot/$ConsoleProgramProjectName/$ConsoleProgramProjectName.csproj"
    dotnet run --project "$PSScriptRoot/$ConsoleProgramProjectName/$ConsoleProgramProjectName.csproj" --no-build

}
finally {
    Set-PSDebug -Off
}
