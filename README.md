# EssentialCSharp

[![Build and Test](https://github.com/IntelliTect/EssentialCSharp/actions/workflows/build-and-test.yml/badge.svg)](https://github.com/IntelliTect/EssentialCSharp/actions/workflows/build-and-test.yml)

本项目包含《C# 12.0本质论》的源代码，清华大学出版社，2024年。

## 英文版在线手稿请访问[EssentialCSharp.com](https://essentialcsharp.com)

## 要求

- [.NET](https://www.microsoft.com/net/core) - 该项目当前经过.NET 8.0、7.0和6.0的测试。
- [Visual Studio](https://visualstudio.microsoft.com/downloads/) - 已包含.NET Core，可以轻松启动。而且，这是一个很棒的IDE，使入门变得简单。
- [Git](https://git-scm.com/book/en/v2/Getting-Started-Installing-Git) - 虽然不是必需的，但是是一个好工具，可以快速下载此代码仓库的简便方式。如果不喜欢使用命令行，[GitKraken](https://www.gitkraken.com/invite/bX2Nqsqr) 是一个很好的使用Git的GUI。

## 运行代码

### Visual Studio

1. **EssentialCSharp.sln** 是项目的主要解决方案，请使用Visual Studio打开此文件。
2. 打开解决方案文件后，选择生成->生成解决方案，使用Visual Studio编译代码。
   - 注意：在执行源代码之前，您需要将和当前章对应的项目设为启动项目来执行的项目。例如，要执行第1章的示例，那么应该右键单击Chapter01项目，然后选择“设为启动项目”。如果选择一个目标章作为启动项目，但输入其他章的代码清单编号，那么会导致异常，显示消息：“不存在和代码清单...对应的章”或者“不存在代码清单...”。
3. 要运行代码，请按F5或选择调试->开始调试。
4. 运行后，程序将提示输入要执行的代码清单编号（例如，18.33）。
   - 注意：如前所述，您只能输入本书的合法代码清单编号。

### Dotnet CLI

1. 从本地终端导航到EssentialCSharp的根目录（根目录是包含`EssentialCSharp.sln`文件的目录）。
2. 从该根目录运行以下命令以还原和构建所有项目：

    ```C#
    dotnet restore
    dotnet build
    ```

3. 要运行代码，请首先导航到您希望执行的章节的项目目录。例如，要执行第1章的示例，您将导航到Chapter01目录（例如：`cd src/Chapter01`）。
4. 然后使用`dotnet run`命令启动程序，并按照提示输入要执行的列表。
   - 注意：您只能输入在当前运行的项目（本例是Chapter01）中的代码清单编号。
5. 还可以使用`dotnet run -p <projectfile>`命令，其中project file是要执行的项目文件的路径（例如，`dotnet run -p .\src\Chapter01\Chapter01.csproj`）。执行时，程序将提示要执行哪个代码清单。

.NET CLI工具的文档可以在这里找到：

<https://docs.microsoft.com/en-us/dotnet/core/tools/>

## 测试

许多列表都有相应的单元测试。

在Visual Studio中，要执行测试，请打开测试项目

并导航到与您要执行的列表对应的测试。然后，在测试方法上右键单击，选择运行测试（Ctrl+R，T）或调试测试（Ctrl+R，Ctrl+T）。或者，打开Test Explorer窗口，并从那里运行一些或所有测试（[更多信息](https://learn.microsoft.com/visualstudio/test/run-unit-tests-with-test-explorer)）。

在dotnet test中，要在所有项目中运行所有测试，请在根EssentialCSharp目录中的命令提示符上运行`dotnet test`。要运行单个项目的测试，请在要执行的测试的测试项目的测试目录中使用dotnet test命令。

## 阅读源代码

在源代码中，有一些可能与在书中查看源代码时看起来不同的地方。这是因为即使书中的示例直接来自这个存储库，但并非所有代码都在书中原样显示。

一些有用的事项：

当您在列表中看到匹配的`#region INCLUDE`和`#endregion INCLUDE`标签时，在这两个标签之间的是在本书中能够看到的源代码。

当列表中有匹配的`#region EXCLUDE`和`#endregion EXCLUDE`标签时，即使这些标签在两个`INCLUDE`标签之间，此部分也会在书中省略，并用`// ...`替换，目的是让你把重点放在讲解的主题上。

此外，任何以`// EXCLUDE`结尾的行都在书中省略了。

## 问题/错误

如果您有任何问题或发现任何错误，请随时打开[本书中文版Git](https://github.com/transbot/EssentialCSharp/discussions)、[Pull Request](https://github.com/transbot/EssentialCSharp/pulls)或[Issue](https://github.com/transbot/EssentialCSharp/discussions)。

另外，请访问[本书中文版主页](https://bookzhou.com)，获取最新资讯、下载和勘误。

## 祝您编码愉快
