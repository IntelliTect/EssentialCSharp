[CmdletBinding()]
param(
    [string]$TestStage,
    [string]$FinalizerOption,
    [int]$TraceLevel=$null
)

Set-StrictMode -Version 3.0

if(($TraceLevel -eq $null) -and 'TraceLevel' -notin $PSBoundParameters.Keys) {
    $TraceLevel = Read-Host -Prompt @"
    Specify the trace level:
    - 0: Turn script tracing off.
    - 1: Trace script lines as they run.
    - 2: Trace script lines, variable assignments, function calls, and scripts.
"@ 
}

#$LibraryProjectName = 'ProcessExit'
$ConsoleProgramProjectName = 'ProcessExitTestProgram.testing'

[string]$projectDirectory = (Join-Path $PSScriptRoot $ConsoleProgramProjectName)

function script:Remove-ProjectDirectory() {
    Get-Item $projectDirectory -ErrorAction Ignore | Remove-Item  -Recurse -Force
}


switch ($TestStage) {
    "create" {
        # Pause if there is already a project directory
        if (("$projectDirectory"| Test-Path) -contains $true) { Start-Sleep 10 }
        Remove-ProjectDirectory
        try {
            Write-Host "`$projectDirectory: $projectDirectory"
            Get-Item $projectDirectory -ErrorAction Ignore | Remove-Item  -Recurse -Force
            Set-PSDebug -Trace $TraceLevel
            dotnet new console --output $projectDirectory
            # No longer needed in .net7.0./C#11
            # Set-Content (Join-Path $projectDirectory 'Directory.Build.props') '<Project><PropertyGroup><Nullable>enable</Nullable></PropertyGroup></Project>'

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
        Remove-ProjectDirectory
    }
    "run"   {
        try{ 
            [string]$projectFile= Join-Path $projectDirectory "$ConsoleProgramProjectName.csproj"

            if(!(Test-Path $projectFile)) {
                Write-Error "Unable to find project file ($projectFile)"
            }

            switch($FinalizerOption) {
                'dispose' {
                    dotnet run --project $projectFile -- -dispose
                }
                'gc' {
                    dotnet run --project $projectFile -- -gc
                }
                'processExit' {
                    dotnet run --project $projectFile
                }
                default {
                    Write-Error "finalizerOption: $FinalizerOption not valid with the testStatus: run"
                }
            }
        }
        finally {
            Set-PSDebug -Off
        }
    }
    default {
        Write-Error "testStatus ('$TestStage') is not valid."
    }
}