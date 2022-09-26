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

try {
    Get-Item .\HelloWorld -ErrorAction Ignore | Remove-Item -Recurse
    $startLocation = Get-Location 
    Set-PSDebug -Trace $traceLevel


    New-Item -ItemType Directory ./HelloWorld
    Set-Location ./HelloWorld/
    dotnet new console
    Get-Content Program.cs
    $codeListing = 
    @"
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Hello. My name is Inigo Montoya.");
    }
}
"@

    $codeListing > Program.cs
    Get-Content Program.cs

    Write-Warning "Remove dotnet build step once we upgrade to version 10"
    # Build with version 10 because dotnet version 6 defaults to an ImplicitUsings element in the project file.
    dotnet build /property:LangVersion=10
    dotnet run --no-build
}
finally {
    Set-PSDebug -Off
    Set-Location $startLocation
}
