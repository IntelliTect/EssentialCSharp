using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace AddisonWesley.Michaelis.EssentialCSharp.Shared;

[ExcludeFromCodeCoverage]
public static class Program
{
    public static async Task Main(string[] args)
    {
        string input;
        IEnumerable<string> stringArguments = Array.Empty<string>();
        Assembly assembly = Assembly.GetEntryAssembly()!;
        if (assembly is null)
        {
            throw new InvalidOperationException("Unable to retrieve the EntryAssembly.");
        }
        string regexMatch = Regex.Match(assembly.GetName().Name!, "\\d{1,2}").Value;

        int chapterNumber = int.Parse(regexMatch);
        if (args.Length == 0)
        {
            Console.Write(
                $"请输入要执行的代码清单的编号(例如，执行代码清单{chapterNumber}.1，就输入\"{chapterNumber}.1\"): ");
            input = Console.ReadLine() ?? string.Empty;
        }
        else
        {
            input = args[0];
            stringArguments = args.Skip(1);
        }

        Console.WriteLine();
        Console.WriteLine("____________________________");
        Console.WriteLine();
        ConsoleColor originalColor = Console.ForegroundColor;

        try
        {
            input = ParseListingName(input);

            Regex reg = new($"Listing{input}\\.+");

            IEnumerable<Type?> targets = assembly.GetTypes().Where(type =>
            {
                return reg.IsMatch(type.FullName!);
            });
            Type? target = targets.FirstOrDefault(item => item?.Name == "Program") ??
                targets.FirstOrDefault();

            if (target is null)
            {
                throw new InvalidOperationException($"不存在代码清单'{input}'。");
            }

            MethodInfo method = target.GetMethod("Main") ??
                // Item doesn't contain an '_' such as set_ or get_ - but really any name with an underscore 
                // would be enough to indicate it wasn't the intended start method.
                target.GetMethods().First(item => !item.Name.Contains("_"));

            string[]? arguments;

            if (!method.GetParameters().Any())
            {
                arguments =
                    null; // If there are no parameters to the method, the arguments parameter should be null.
            }
            else
            {
                if (!stringArguments.Any())
                {
                    arguments = GetArguments();
                }
                else
                {
                    arguments = stringArguments.ToArray();
                }
            }

            string? output = await InvokeMethodUsingReflectionAsync(method, arguments);

            if (output is { })
            {
                Console.WriteLine($"Result: {output}");
            }
        }
#pragma warning disable CA1031 // Do not catch general exception types
        catch (System.IO.FileNotFoundException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----Exception----");
            Console.WriteLine($"不存在和代码清单{input}对应的章。");
        }
#pragma warning restore CA1031 // Do not catch general exception types
        catch (TargetParameterCountException exception)
        {
            throw new InvalidOperationException(
                $"调用代码清单'{input}'时出现严重错误。\n",
                exception);
        }
        catch (InvalidOperationException exception)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----异常----");
            Console.WriteLine(exception.Message);
        }
#pragma warning disable CA1031 // Do not catch general exception types
        catch (Exception exception)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----异常----");
            if (exception.InnerException is null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(string.Format("代码清单{0}抛出类型为{1}的一个异常。", input,
                    exception.GetType()));
            }
            else
            {
                // Use throw exception.InnerException instead for earlier
                // versions of the framework.
                System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(
                    exception.InnerException).Throw();
            }
        }
#pragma warning restore CA1031 // Do not catch general exception types
        finally
        {
            Console.ForegroundColor = originalColor;

            Console.WriteLine();
            Console.WriteLine("____________________________");
            Console.WriteLine("结束代码清单" + input);
            Console.Write("按任意键退出。");
            Console.ReadKey();
        }
    }

    public static async ValueTask<string?> InvokeMethodUsingReflectionAsync(MethodInfo method, string[]? arguments)
    {
        // Note: 'arguments' here are the array of commandLine args, so 
        // it is the first item in the "parameters" array specified to the 
        // Invoke method.
        object? result = method.Invoke(null,
        parameters: arguments is null ? Array.Empty<object>() : new object[] { arguments! });

        if (method.ReturnType == typeof(void))
        {
            return null;
        }
        else if (result is null)
        {
            return "<null>";
        }
        else if (method.GetCustomAttribute(typeof(AsyncIteratorStateMachineAttribute), false) is not null)
        {
            return result switch
            {
                IAsyncEnumerable<int> asyncEnumerable => await AggregateToString(asyncEnumerable),
                IAsyncEnumerable<string> asyncEnumerable => await AggregateToString(asyncEnumerable),
                null => throw new InvalidOperationException($"Given an {nameof(IAsyncEnumerable<string>)} method, the result is unexpectedly null."),
                _ => throw new NotImplementedException($"This {nameof(IAsyncEnumerable<string>)} type parameter is not implemented."),
            };
        }
        else if (method.GetCustomAttribute(typeof(AsyncStateMachineAttribute), false) is not null)
        {
            switch (result)
            {
                case Task task when method.ReturnType == typeof(Task):
                    await task;
                    return null;
                case Task<int> task:
                    return $"{await task}";
                case Task<string> task:
                    return await task;
                case ValueTask<int> task:
                    return $"{await task}";
                case ValueTask<string> task:
                    return await task;
                default:
                    dynamic awaitable = result!;
                    await awaitable;
                    return awaitable.GetAwaiter().GetResult();
            }
        }
        else
        {
            return $"{result}";
        }
    }

    private static async Task<string?> AggregateToString<T>(IAsyncEnumerable<T> asyncEnumerable)
    {
        List<string> list = new();
        await foreach (T item in asyncEnumerable)
        {
            list.Add($"{item}");
        }
        return string.Join(", ", list);
    }

    private static string[] GetArguments()
    {
        string[] args;

        Console.WriteLine();
        Console.WriteLine(
            "请提供要向程序的main方法提供的参数，不同参数以空格分隔。具体要求请参见相应的代码清单。或者直接按Enter键传递null值：");
        string? userArguments = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine();

        if (userArguments is not null)
        {
            userArguments = userArguments.Trim();
        }

        if (string.IsNullOrWhiteSpace(userArguments))
        {
            args = Array.Empty<string>();
        }
        else
        {
            args = userArguments.Split(new[] { ' ' });
        }

        return args;
    }

    private static string ParseListingName(string listing)
    {
        var appendices = new List<string> { "A", "B", "C", "D" };

        string chapterName = "";

        string[] chapterListing = listing.Split('.', '-');
        listing = string.Empty;

        int startPosition;

        if (!int.TryParse(chapterListing[0], out _))
        {
            startPosition = 1;
            listing += chapterListing[0].ToUpper() + ".";
            chapterName = "Chapter" + (appendices.Contains(chapterListing[0].ToUpper()) ? "App" : "") +
                          chapterListing[0];
        }
        else
        {
            startPosition = 0;
        }

        for (int index = startPosition; index < chapterListing.Length; index++)
        {
            if (index == startPosition && string.IsNullOrEmpty(chapterName))
                chapterName = "Chapter" + chapterListing[index].PadLeft(2, '0');
            listing += chapterListing[index].PadLeft(2, '0')
                       + ((index + 1 != chapterListing.Length) ? "." : "");
        }

        string[] parts = listing.Split('.'); // 02.01.02.06
        if (parts.Length > 2)
        {
            listing = $"{parts[0]}.{parts[1]}To{string.Join('.', parts.Skip(3))}";
        }

        return listing.Replace('.', '_');
    }
}