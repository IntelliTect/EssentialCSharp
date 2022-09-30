[CmdletBinding()]
param(
    [int]$traceLevel,
    [string]$finalizerOption,
    [string]$testStatus
   
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

[string]$projectDirectory = (Join-Path $PSScriptRoot $ConsoleProgramProjectName)

switch ($testStatus) {
    "create" {
        try {
            Write-Host "`$projectDirectory: $projectDirectory"
            Get-Item $projectDirectory -ErrorAction Ignore | Remove-Item  -Recurse
            Set-PSDebug -Trace $traceLevel
            dotnet new Console --output $projectDirectory
            Set-Content (Join-Path $projectDirectory 'Directory.Build.props') '<Project><PropertyGroup><Nullable>enable</Nullable></PropertyGroup></Project>'

            $SutCSFile = split-path -leaf $MyInvocation.MyCommand.Definition
            $SutCSFile = Join-Path $PSScriptRoot "$([IO.Path]::GetFileNameWithoutExtension($SutCSFile)).cs"
            if(-not (Test-Path $SutCSFile)) { throw "Unable to find the file with the type to export ('$SutCSFile')"}
        
            $codeListing = @('namespace ProcessExitTestProgram') + (
                Get-Content $SutCSFile | Where-Object { $_ -notlike 'namespace *'})
            $codeListing > (Join-Path $projectDirectory 'Program.cs')
            Get-Content (Join-Path $projectDirectory 'Program.cs')  # Display the listing

        }catch{
            throw "Unable to create project"
        }
    }
    "cleanup" { 
        Get-Item $projectDirectory -ErrorAction Ignore | Remove-Item  -Recurse
    }
    "run"   {
        try{ 
            [string]$projectFile= Join-Path $projectDirectory "$ConsoleProgramProjectName.csproj"

            if(!(Test-Path $projectFile)) {
                Write-Error "Unable to find project file ($projectFile)"
            }

            if($finalizerOption -eq 'dispose'){
            dotnet run --project $projectFile -- -dispose
            }
            elseif($finalizerOption -eq 'gc'){
            dotnet run --project $projectFile -- -gc
            }
            elseif($finalizerOption -eq 'processExit'){
            dotnet run --project $projectFile
            }
            else{
                Write-Error "finalizerOption: $finalizerOption not valid with the testStatus: run"
            }
        }
        finally {
            Set-PSDebug -Off
        }
    }
}