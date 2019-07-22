# EssentialCSharp

This project contains the source code for the book **Essential C#** by Mark Michaelis (Addison-Wesley).

## Sample Code Guide

Ensure one of the following frameworks is installed at the latest version.

* [.NET Framework](https://www.microsoft.com/net/targeting) (Windows)
* [.NET Core](https://www.microsoft.com/net/core) (All)

[Visual Studio 2017](https://www.visualstudio.com) contains the .NET Framework runtime as well as gives options to install .NET Core.  Not to mention, it's a great IDE that makes it easy to get started.

### Download the Code

#### Local Copy  

Open a console and change the working directory to the desired project location. 
```
$ git clone https://github.com/IntelliTect/EssentialCSharp.git
$ cd ./EssentialCSharp/
```
The source code is the most recently published edition of the book and this is the default branch following the clone command.  However, you can switch to a different branch, v6.0 for example, with the command:
```
$ git checkout v6.0
```

### Build

**EssentialCSharp.sln** is the project's main solution, open this with Visual Studio and _Build All_.
 
 For those using the command line, build all the projects from the /EssentialCSharp/ directory with these commands:
```
$ dotnet restore EssentialCSharp.sln
$ dotnet build EssentialCSharp.sln
```
### Run

Navigate to an individual project in the /EssentialCSharp/src/(project)/ directory and run the code. The example below is for Chapter01 with the user entering _1.1_ to execute the listing number.

To run a listing you must run the the project that contains it. For example, to run Listing 1.1 you must navigate to Chapter01 in the 
_Solution Explorer_ and set Chapter01 as the startup project. In Rider this can be done by locating the desired project in the _Explorer_ tab, right clicking on the project and clicking _run_.

```
$ cd ./src/Chapter01/
$ dotnet run
Enter the listing number to execute (e.g. For Listing 1.1 enter "1.1"): 1.1

____________________________

Hello. My name is Inigo Montoya.

____________________________
End of Listing 01_01
Press any key to exit.
$
```

Documentation for .NET CLI tools can be found here: 

https://docs.microsoft.com/en-us/dotnet/core/tools/


## Batch Testing
Use one of the following scripts to execute a batch test on all the projects.

* /EssentialCSharp/RunTests.ps1 **(Windows)**
* /EssentialCSharp/RunTests.sh **(Linux/Mac)**

If running on Linux you may need to give the script execution permission.  From the /EssentialCSharp/ directory:
```
$ chmod +x ./RunTests.sh
$ ./RunTests.sh
```

## Build Status
* *Windows*: [![Build Status](https://dev.azure.com/intelliTect/EssentialCSharp/_apis/build/status/Branch%20V7%20-%20EssentialCSharp-Windows?branchName=v7.0)](https://dev.azure.com/intelliTect/EssentialCSharp/_build/latest?definitionId=43&branchName=v7.0)
![Azure DevOps tests (branch)](https://img.shields.io/azure-devops/tests/intelliTect/EssentialCSharp/43/v7.0.svg)
![Azure DevOps coverage (branch)](https://img.shields.io/azure-devops/coverage/intelliTect/EssentialCSharp/43/v7.0.svg)
* *Linux*: [![Build Status](https://dev.azure.com/intelliTect/EssentialCSharp/_apis/build/status/Branch%20V7%20-%20EssentialCSharp-Linux?branchName=v7.0)](https://dev.azure.com/intelliTect/EssentialCSharp/_build/latest?definitionId=42&branchName=v7.0)
![Azure DevOps tests (branch)](https://img.shields.io/azure-devops/tests/intelliTect/EssentialCSharp/42/v7.0.svg)
![Azure DevOps coverage (branch)](https://img.shields.io/azure-devops/coverage/intelliTect/EssentialCSharp/42/v7.0.svg)