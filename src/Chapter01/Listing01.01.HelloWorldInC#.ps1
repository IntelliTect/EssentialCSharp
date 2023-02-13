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

try {
    Get-Item .\HelloWorld -ErrorAction Ignore | ForEach-Object { Start-Sleep 10;Remove-Item -Recurse $_ }
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
    dotnet run
}
finally {
    Set-PSDebug -Off
    Set-Location $startLocation
    Get-Item .\HelloWorld -ErrorAction Ignore | Remove-Item -Recurse
}
