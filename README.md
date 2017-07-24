# EssentialCSharp

This project contains the source code for the book **Essential C#** by Mark Michaelis (Addison-Wesley).

## Sample Code Guide

Ensure one of the following frameworks is installed at the latest version.

* [.NET Framework](https://www.microsoft.com/net/targeting) (Windows)
* [.NET Core](https://www.microsoft.com/net/core) (All)

[Visual Studio 2017](https://www.visualstudio.com) contains the .NET Framework runtime as well as gives options to install .NET Core.  Not to mention, it's a great IDE that makes it easy to get started.

### Download the Code

#### Local Copy  

Open a console and change the working directory to the desired project location. Once the repo has been cloned, checkout the v7.0 branch.
```
$ git clone https://github.com/IntelliTect/EssentialCSharp.git
$ cd ./EssentialCSharp/
$ git checkout v7.0
```

#### Initialize and Update _TestTools_ 

_TestTools_ is IntelliTect's code testing framework for .NET console applications.  From the same console:
```
$ git submodule update --init --remote
$ cd ./submodules/TestTools
$ git checkout master
$ git pull
```

### Build

**EssentialCSharp.sln** is the project's main solution, open this with Visual Studio and _Build All_.
 
 For those using the command line, build all the projects from the /EssentialCSharp/ directory with these commands:
```
$ cd ../../
$ dotnet restore EssentialCSharp.sln
$ dotnet build EssentialCSharp.sln
```
### Run

Navigate to an individual project in the /EssentialCSharp/src/(project)/ directory and run the code. The example below is for Chapter01 with the user entering _1.1_ to execute the listing number.

```
$ cd ./src/Chapter01/
$ dotnet run
Enter the listing number to execute (e.g. For Listing 18.1 enter "18.1"): 1.1

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
