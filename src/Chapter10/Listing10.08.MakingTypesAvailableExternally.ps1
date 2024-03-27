[CmdletBinding()]
param(
    [int]$traceLevel
)

if('traceLevel' -notin $PSBoundParameters.Keys) {
    $traceLevel = Read-Host -Prompt @"
    Specify the trace level:
    - 0: Turn script tracing off.
    - 1: Trace script lines as they run.
    - 2: Trace script lines, variable assignments, function calls, and scripts.

"@ 
}

[string]$LibraryProjectName = 'GeoCoordinates'
[string]$ConsoleProgramProjectName = 'GeoCoordinate.testing'

# Path to the file containing the TargetFrameworks element
[string]$TargetFrameworksPropsFile = "$PSScriptRoot/../../Common.props"

[xml]$directoryBuildPropsXml = ([xml](Get-Content "$PSScriptRoot/../../Directory.Build.props"))
[string]$langVersion = $directoryBuildPropsXml.Project.PropertyGroup.LangVersion
[string]$SutCSFile = split-path -leaf $MyInvocation.MyCommand.Definition
[string]$SutCSFile = "$PSScriptRoot/$([IO.Path]::GetFileNameWithoutExtension($SutCSFile)).cs"
if(-not (Test-Path $SutCSFile)) { throw "Unable to find the file with the type to export ('$SutCSFile')"}

function script:Remove-ProjectDirectory() {
   Get-Item "$PSScriptRoot/$LibraryProjectName","$PSScriptRoot/$ConsoleProgramProjectName" -ErrorAction Ignore | Remove-Item  -Recurse -Force
}

try {
    if (("$PSScriptRoot/$LibraryProjectName","$PSScriptRoot/$ConsoleProgramProjectName"| Test-Path) -contains $true) { Start-Sleep 5 }
    Remove-ProjectDirectory
    Set-PSDebug -Trace $traceLevel
    
    if([string]::IsNullOrEmpty($langVersion))
    {
        throw "LangVersion not set."
    }

    # Specifying langVersion as dotnet new appears to ignore the Directory.Build.props file.
    dotnet new console --langVersion $langVersion --output "$ConsoleProgramProjectName"
    $projectFilePath = "$PSScriptRoot/$ConsoleProgramProjectName/$($ConsoleProgramProjectName).csproj"
    $updatedContent =(Get-Content $projectFilePath) | ? { $_ -notlike '*TargetFramework*'} 
    Set-Content -Value $updatedContent -Path $projectFilePath

    # Add reference to Common.props
    [xml]$projectFileContent = Get-Content -Path $projectFilePath
    $importElement = $projectFileContent.CreateElement("Import", $projectFileContent.DocumentElement.NamespaceURI)
    $importElement.SetAttribute("Project", $TargetFrameworksPropsFile)
    $projectFileContent.Project.InsertAfter($importElement, $projectFileContent.Project.FirstChild)
    $projectFileContent.Save($projectFilePath)

    dotnet new classlib  --langVersion $langVersion --output "$LibraryProjectName"
    $projectFilePath = "$PSScriptRoot/$LibraryProjectName/$($LibraryProjectName).csproj"
    $updatedContent =(Get-Content $projectFilePath) | ? { $_ -notlike '*TargetFramework*'} 
    Set-Content -Value $updatedContent -Path $projectFilePath
    Remove-Item "$PSScriptRoot/$LibraryProjectName/class1.cs"
    
    # Add reference to Common.props
    [xml]$projectFileContent = Get-Content -Path $projectFilePath
    $importElement = $projectFileContent.CreateElement("Import", $projectFileContent.DocumentElement.NamespaceURI)
    $importElement.SetAttribute("Project", $TargetFrameworksPropsFile)
    $projectFileContent.Project.InsertAfter($importElement, $projectFileContent.Project.FirstChild)
    $projectFileContent.Save($projectFilePath)
    
    #New-Item -ItemType Directory "$PSScriptRoot/$LibraryProjectName"
    $codeListing = @('namespace GeoCoordinates;') + (
        Get-Content $SutCSFile | 
            Select-Object -Skip 1)
    $codeListing > "$PSScriptRoot/$LibraryProjectName/GeoTypes.cs"
    Get-Content "$PSScriptRoot/$LibraryProjectName/GeoTypes.cs"  # Display the listing
    dotnet add "$PSScriptRoot/$ConsoleProgramProjectName/$ConsoleProgramProjectName.csproj" `
        reference "$PSScriptRoot/$LibraryProjectName/$LibraryProjectName.csproj"
    $codeListing = @"
namespace $ConsoleProgramProjectName;
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
"@ 
    $codeListing > "$PSScriptRoot/$ConsoleProgramProjectName/Program.cs"
    Get-Content "$PSScriptRoot/$ConsoleProgramProjectName/Program.cs" # Display the listing

# Load the file containing the TargetFrameworks element as an XML document
[xml]$propsFile = Get-Content -Path $TargetFrameworksPropsFile

# Extract the TargetFrameworks element value
$targetFrameworks = $propsFile.Project.PropertyGroup.TargetFrameworks -split ';'

# Iterate over the target frameworks and execute commands for each
foreach ($framework in $targetFrameworks) {
    dotnet build "$PSScriptRoot/$ConsoleProgramProjectName/$ConsoleProgramProjectName.csproj" --framework $framework
    dotnet run --project "$PSScriptRoot/$ConsoleProgramProjectName/$ConsoleProgramProjectName.csproj" --no-build --framework $framework
}

}
finally {
    Remove-ProjectDirectory
    Set-PSDebug -Off
}
