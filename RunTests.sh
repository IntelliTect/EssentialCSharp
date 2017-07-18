#!/bin/bash
> Test.Results.txt
if [ ${BASH_VERSION:0:1} -lt 4 ]
then
shopt -s
projPath=./src/**/*.Test*.csproj
else
shopt -s globstar
projPath=**/*.Test*.csproj
fi
for csproj in $projPath
do
echo $xls
dotnet test "$csproj" | tee -a Test.Results.txt
done