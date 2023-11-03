# EssentialCSharp

[![Build and Test](https://github.com/IntelliTect/EssentialCSharp/actions/workflows/build-and-test.yml/badge.svg)](https://github.com/IntelliTect/EssentialCSharp/actions/workflows/build-and-test.yml)

This project contains the source code for the book **Essential C#** by Mark Michaelis (Addison-Wesley).

## Checkout the online resource that walks through all code samples in this repository at [EssentialCSharp.com](https://essentialcsharp.com)

## Requirements

- [.NET](https://www.microsoft.com/net/core) - This project is currently tested against .NET 8.0, 7.0, and 6.0.
- [Visual Studio](https://visualstudio.microsoft.com/downloads/) - Already contains .NET Core to get up and running. Not to mention, it's a great IDE that makes it easy to get started.
- [Git](https://git-scm.com/book/en/v2/Getting-Started-Installing-Git) - While not required, a good tool to get used to, and easy way to download this code repository quickly. [GitKraken](https://www.gitkraken.com/invite/bX2Nqsqr) is a great GUI for using Git if you prefer not using the command line.

## Download the Code

### Local Copy

Open a console and change the working directory to the desired project location.

```bash
git clone https://github.com/IntelliTect/EssentialCSharp.git
cd ./EssentialCSharp/
```

The source code is the most recently published edition of the book and this is the default branch following the clone command. However, you can switch to a different branch, v12.0 for example, with the command:

```bash
git checkout v12.0
```

## Running the Code

### Visual Studio

1. **EssentialCSharp.sln** is the project's main solution, open this with Visual Studio.
2. After opening the solution file, use the Build->Build Solution menu to compile the code with Visual Studio.
   - NOTE: Before you can execute the source code, you need to select which project to execute by selecting the associated chapter’s project as the startup project. For example, to execute the samples in Chapter 1, you would right-click on the Chapter01 project and choose Set as Startup Project. Failure to choose the correct chapter will result in an exception with the message “Error, could not run the Listing…” when you specify the listing number at execution time.
3. To run the code, press F5 or select Debug->Start Debugging from the menu.
4. Once running, the program will prompt for the listing (e.g., 18.33) that you wish to execute.
    - NOTE: As mentioned earlier, you can enter only listings from the project that was set to start up.

### Dotnet CLI

1. Navigate to the root directory of the EssentialCSharp from your local terminal (the root directory is the one that contains the `EssentialCSharp.sln` file).
2. From that root directory, run the following commands to restore and build all the projects:

    ```C#
    dotnet restore
    dotnet build
    ```

3. To run the code, first navigate to the project directory of the chapter you wish to execute. For example, to execute the samples in Chapter 1, you would navigate to the Chapter01 directory (ex: `cd src/Chapter01`).
4. Then use the `dotnet run` command to begin the program and follow the prompts for which listing to execute.
    - NOTE: You can enter only listings from the project that is set to run (Chapter01 in this sample).
5. Instead of navigating to the chapter directory of the project you want to run, you can use the `dotnet run -p <projectfile>` command where project file is the path to the project file you are trying to execute (e.g., `dotnet run -p .\src\Chapter01\Chapter01.csproj`). Once executing, the program will prompt for which listing to execute and then proceed with that listing.

Documentation for .NET CLI tools can be found here:

<https://docs.microsoft.com/en-us/dotnet/core/tools/>

## Testing

Many of the listings have corresponding unit tests.

In Visual Studio, to execute a test, open the test project and navigate to the test corresponding to the listing you wish to execute. From there, right-click on the test method and choose either Run Tests (Ctrl+R, T) or Debug Tests (Ctrl+R, Ctrl+T). Alternatively, open your Test Explorer window and run some or all of the tests from there ([More Information](https://learn.microsoft.com/visualstudio/test/run-unit-tests-with-test-explorer))

In dotnet test, to run all the tests across all projects, run `dotnet test` on the command prompt in the root EssentialCSharp directory (the root directory is the one that contains the `EssentialCSharp.sln` file). To run the tests for a single project, use the dotnet test command from the project tests directory of the test you are looking execute.

## Reading the Source Code

In the source code there are some things that may look different than when you look at the source code in the book. This is because even though the examples in the book come directly from this repository, not all of the code is shown in the book like it is here.

Some helpful things to note:

When you see matching `#region INCLUDE` and `#endregion INCLUDE` tags in a listing, between these two tags are where the source code that is able to be seen in this book lies.

When there are matching `#region EXCLUDE` and `#endregion EXCLUDE` tags in a listing, even if these are within two `INCLUDE` tags, this section is omitted from being visible in the book and replaced with a `// ...` just to try and bring more clarity to the point that is actually being taught in that listing.

In addition, any line that ends with a `// EXCLUDE` is a line that is omitted from being seen in the book.

## Questions/Bugs

If you have any questions or find any bugs, please feel free to open a [Discussion](https://github.com/IntelliTect/EssentialCSharp/discussions), [Pull Request](https://github.com/IntelliTect/EssentialCSharp/pulls), or [Issue](https://github.com/IntelliTect/EssentialCSharp/discussions).

If there is an issue with [EssentialCSharp.com](EssentialCSharp.com), please checkout the [EssentialCSharp.Web Repository](https://github.com/IntelliTect/EssentialCSharp.Web)

## Happy Coding
