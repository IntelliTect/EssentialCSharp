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

if($testStatus -eq "create"){
try {
    Get-Item "$PSScriptRoot\$ConsoleProgramProjectName" -ErrorAction Ignore | Remove-Item  -Recurse
    Set-PSDebug -Trace $traceLevel
    dotnet new Console --output "$PSScriptRoot\$ConsoleProgramProjectName"
  
    $SutCSFile = split-path -leaf $MyInvocation.MyCommand.Definition
    $SutCSFile = "$PSScriptRoot\$([IO.Path]::GetFileNameWithoutExtension($SutCSFile)).cs"
    if(-not (Test-Path $SutCSFile)) { throw "Unable to fine the file with the type to export ('$SutCSFile')"}
  
    $codeListing = @('namespace ProcessExitTestProgram') + (
        Get-Content $SutCSFile | 
            Select-Object -Skip 1)
    $codeListing > "$PSScriptRoot\$ConsoleProgramProjectName\Program.cs"
    Get-Content "$PSScriptRoot\$ConsoleProgramProjectName\Program.cs"  # Display the listing
    
    
}catch{
    Write-Error "Unable to create project"
}
 
}

if($testStatus -eq "cleanup"){ 
    Get-Item "$PSScriptRoot\$ConsoleProgramProjectName" -ErrorAction Ignore | Remove-Item  -Recurse
}

if($testStatus -eq "run"){
  try{ 
    if($finalizerOption -eq 'dispose'){
    dotnet run -p "$PSScriptRoot\$ConsoleProgramProjectName\$ConsoleProgramProjectName.csproj" -- -dispose
    }
    elseif($finalizerOption -eq 'gc'){
    dotnet run -p "$PSScriptRoot\$ConsoleProgramProjectName\$ConsoleProgramProjectName.csproj" -- -gc
    }
    elseif($finalizerOption -eq 'processExit'){
    dotnet run -p "$PSScriptRoot\$ConsoleProgramProjectName\$ConsoleProgramProjectName.csproj"
    }
    else{
        Write-Error "finalizerOption: $finalizerOption not valid with the testStatus: run"
    }

}
finally {
    Set-PSDebug -Off
    
}
}