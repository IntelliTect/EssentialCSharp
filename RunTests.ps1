dotnet clean
dotnet restore
dir -recurse -include *.Tests.csproj |  %{dotnet test $_} > Test.Results.txt
./CalculateResults.ps1