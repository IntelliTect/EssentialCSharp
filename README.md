# EssentialCSharp

This is the home for the the book Essential C# by Mark Michaelis (Addison-Wesley).

## About

The book has three main functions:

* It provides comprehensive coverage of the C# language, going beyond a tutorial and offering a foundation to begin effective software development projects.

* It offers insight into complex programming paradigms and provides in-depth coverage of the features introduced in the latest version of the language.

* It serves as a timeless reference.

## Features

* Coding Guidelines
* Code Samples
* Mind Maps
* Helpful Notes

## Organization

* Figures
* Table of Contents
* Tables
* Foreword
* Preface
* Acknowledgements
* About the Authors
* A-D Appendices
* Index
* Sample Code 

|Chapter  |Title     |Chapter  |Title    |Chapter  |Title     |
|:-------:|----------|:-------:|---------|:-------:|----------|
|1|Introducing C#|8|Value Types|15|LINQ with Query Expressions|
|2|Data Types|9|Well-Formed Types|16|Building Custom Collections|
|3|Operators and Control Flow|10|Exception Handling|17|Reflection, Attributes, and Dynamic Programming|
|4|Methods and Parameters|11|Generics|18|Multithreading|
|5|Classes|12|Delegates and Lambda Expressions|19|Thread Synchronization|
|6|Inheritance|13|Events|20|Platform Interoperability and Unsafe Code|
|7|Interfaces|14|Collection Interfaces with Standard Query Operators|21|The Common Language Infrastructure

## Sample Code

The book has numerous amounts of C# code that needs to be validated.  If you need assistance building and running the code follow the guide below.


#### Windows

In order to Build and Run C# you'll need to obtain the .NET Framework and the .NET Framework Software Development Kit(SDK).  There are two primary options:

* .NET Framework SDK
* .NET Core

Visual Studio 2017 comes bundled with the .NET SDK and allows you to download .NET Core as an option.  Get the "Community" version free [here](https://www.microsoft.com/net/download/framework).

If you'd like to use a text editor such as Visual Studio Code, .NET Core is the way to go.  Find instructions for installation at [Microsoft .NET Core](https://www.microsoft.com/net/core#windowscmd).  You'll need the Command-Line Tools to operate with a text editor.

Note: Some users, including myself, have had some issues installing Visual Studio 2017 with the .NET 4.7 SDK.  The solution is to install the .NET Framework Developer Pack on top of Visual Studio.  Download [here](https://www.microsoft.com/net/targeting). Microsoft's explanation is below: 

> Rakesh Ranjan Singh [MSFT] · Jun 09 at 12:27 AM

> Thank you for your feedback! We have determined that [the inability to install .NET SDK 4.7] is not a bug. During VS 2017 15.1 release, '.NET 4.7 development tools' component was added. This is an optional component that is not recommended by default. This component is applicable on W10 Creators Edition or above Win10 OS.You may choose to either select '.NET 4.7 development tools' component or individual components ( .NET 4.7 Targeting Pack and .NET 4.7 SDK ) components. On May 2nd, 2017, .NET 4.7 was made available in downlevel OSes (blog) . In future release of VS 2017, .NET 4.7 development tools will be available in supported downlevel OS as well. However, component will be still remain optional.

#### Linux/Mac: 

* .Net Core
* ~~Mono~~ (not fully C# 7.0 vetted) 

.Net Core is your best bet for a Linux/Mac environment. Visual Studio is available for Mac, however, you will still need to install the .Net Core SDK in order to take full advantage.  Follow installation instructions at [Microsoft .NET Core](https://www.microsoft.com/net/core).

### Obtaining the Code

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

### Build

With Visual Studio you can build all the projects by opening **EssentialCSharp.sln** and clicking *Build* on the *Title Menu* then *Build All*. 
 
 For those using the command-line, build all the projects from the /EssentialCSharp/ directory with these commands:
```
$ dotnet restore EssentialCSharp.sln
$ dotnet build EssentialCSharp.sln
```
### Run

You can run your projects with Visual Studio by focusing your project and then in the *Title Menu* select *Run* -> *Start Debugging*.

Command-line: Navigate to an individual project in the /EssentialCSharp/src/(project)/ directory and run the code. For instance, Chapter01 with the user entering "1.1" for the listing number to execute.

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
