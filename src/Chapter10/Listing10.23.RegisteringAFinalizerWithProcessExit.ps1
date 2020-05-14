[CmdletBinding()]
param(
    [int]$traceLevel,
    [int]$dispose,
    [int]$gc
)
if('traceLevel' -notin $PSBoundParameters.Keys) {
    $traceLevel = Read-Host -Prompt @"
    Specifiy the trace level:
    - 0: Turn script tracing off.
    - 1: Trace script lines as they run.
    - 2: Trace script lines, variable assignments, function calls, and scripts.

"@ 
}

#$LibraryProjectName = 'ProcessExit'
$ConsoleProgramProjectName = 'ProcessExitTestProgram'

try {
    Get-Item "$PSScriptRoot\$ConsoleProgramProjectName" -ErrorAction Ignore | Remove-Item  -Recurse
    Set-PSDebug -Trace $traceLevel
    dotnet new Console --output "$ConsoleProgramProjectName"
         #dotnet new ClassLib  --langVersion '8.0' --output "$LibraryProjectName" 
    #Remove-Item "$PSScriptRoot\$LibraryProjectName\class1.cs"
    $SutCSFile = split-path -leaf $MyInvocation.MyCommand.Definition
    $SutCSFile = "$PSScriptRoot\$([IO.Path]::GetFileNameWithoutExtension($SutCSFile)).cs"
    if(-not (Test-Path $SutCSFile)) { throw "Unable to fine the file with the type to export ('$SutCSFile')"}
    #New-Item -ItemType Directory "$PSScriptRoot\$LibraryProjectName"
    $codeListing = @('namespace ProcessExitTestProgram') + (
        Get-Content $SutCSFile | 
            Select-Object -Skip 1)
    $codeListing > "$PSScriptRoot\$ConsoleProgramProjectName\Program.cs"
    Get-Content "$PSScriptRoot\$ConsoleProgramProjectName\Program.cs"  # Display the listing
    #dotnet add "$PSScriptRoot\$ConsoleProgramProjectName\$ConsoleProgramProjectName.csproj"
    
    dotnet run -p "$PSScriptRoot\$ConsoleProgramProjectName.csproj"

}
finally {
    Set-PSDebug -Off
}