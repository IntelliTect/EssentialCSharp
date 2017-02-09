#!/bin/bash
shopt -s globstar
for csproj in **/*.Test*.csproj
do
echo $xls
dotnet test "$csproj"
done
