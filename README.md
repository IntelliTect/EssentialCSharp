# EssentialCSharp

This project contains the source code for the book Essential C# by Mark Michaelis (Addison-Wesley).

## Prerequisites

* .NET Core SDK
* Git

#### Windows:

Follow instructions at [Microsoft .NET Core](https://www.microsoft.com/net/core#windowscmd) and ensure that you install **.NET Core SDK** by selecting **Command line / other** 

Note:  Visual Studio 2017 does not install the CLI tools required for some tests.  Additionally install the CLI tools if you install .NET Core through Visual Studio.

#### Linux/Mac: 

Follow instructions at [Microsoft .NET Core](https://www.microsoft.com/net/core) to get .NET Core SDK.  All non-windows installs include the CLI tools.

## Obtaining the Code

#### Local Copy  

Open a console/terminal and change the working directory to the desired project location.
```
$ git clone https://github.com/IntelliTect/EssentialCSharp.git
```

#### Initialize "TestTools" 

TestTools is IntelliTect's code testing framework for .NET console applications.  From the same terminal/console:

```
$ cd ./EssentialCSharp/
$ git submodule update --init --remote
```

## Build

 You can build all the projects in **EssentialCSharp.sln** with the following commands run from the /EssentialCSharp/ directory:
```
$ dotnet restore EssentialCSharp.sln
$ dotnet build EssentialCSharp.sln
```
## Run

Navigate to an individual project in the /EssentialCSharp/src/(project)/ directory and run the code. For instance, Chapter01 with the user entering "1.1" for the listing number to execute.

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

* ./EssentialCSharp/RunTests.ps1 **(Windows)**
* ./EssentialCSharp/RunTests.sh **(Linux/Mac)**
