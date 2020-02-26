#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;
using System.Diagnostics.CodeAnalysis;

namespace AddisonWesley.Michaelis.EssentialCSharp.Shared
{
    [ExcludeFromCodeCoverage]
    public class Program
    {
        public static void Main(string[] args)
        {
            string input;
            IEnumerable<string> stringArguments = new string[0];
            Assembly assembly = Assembly.GetEntryAssembly()!;
            if (assembly is null)
            {
                throw new InvalidOperationException("Unable to retrieve the EntryAssembly.");
            }
            string regexMatch = Regex.Match(assembly.GetName().Name, "\\d{1,2}").Value;

            int chapterNumber = int.Parse(regexMatch);
            if (args.Length == 0)
            {
                Console.Write(
                    $"Enter the listing number to execute (e.g. For Listing {chapterNumber}.1 enter \"{chapterNumber}.1\"): ");
                input = Console.ReadLine();
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

                Regex reg = new Regex($"{input}\\.+");
                Type? target = assembly.GetTypes().FirstOrDefault(type =>
                {
                    return reg.IsMatch(type.FullName!);
                });
                if (target == null)
                {
                    throw new InvalidOperationException($"There is no listing '{input}'.");
                }

                MethodInfo method = target.GetMethods().First();
                string[]? arguments;
                void InvokeMethodUsingReflection()
                {
                    // Note: 'arguments' here are the array of commandline args, so they 
                    // it is the first item in the "parameters" array specified to the 
                    // Invoke method.
                    object? result = method.Invoke(null,
                        parameters: arguments is null ? new object[0] : new object[] { arguments! });

                    if (method.ReturnType != typeof(void))
                    {
                        Console.WriteLine($"Result: {result}");
                    }
                }

                if (!method.GetParameters().Any())
                {
                    arguments =
                        null; // If there are no parameters to the method, the arguments parameter should be null.
                }
                else
                {
                    if (stringArguments.Count() == 0)
                    {
                        arguments = GetArguments();
                    }
                    else
                    {
                        arguments = stringArguments.ToArray();
                    }
                }

                if (method.GetCustomAttributes(typeof(STAThreadAttribute), false).Any())
                {
                    Thread thread = new Thread(() =>
                    {
                        InvokeMethodUsingReflection();
                    });
                }
                else
                {
                    InvokeMethodUsingReflection();
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("----Exception----");
                Console.WriteLine($"There is no chapter corresponding to listing {input}.");
            }
            catch (TargetParameterCountException exception)
            {
                throw new InvalidOperationException(
                    $"Fatal Error invoking Listing '{input}'.\n",
                    exception);
            }
            catch (InvalidOperationException exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("----Exception----");
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("----Exception----");
                if (exception.InnerException is null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(string.Format("Listing {0} threw an exception of type {1}.", input,
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
            finally
            {
                Console.ForegroundColor = originalColor;

                Console.WriteLine();
                Console.WriteLine("____________________________");
                Console.WriteLine("End of Listing " + input);
                Console.Write("Press any key to exit.");
                Console.ReadKey();
            }
        }

        private static string[] GetArguments()
        {
            string[] args;

            Console.WriteLine();
            Console.WriteLine(
                "Listing uses arguments for main method provided by user. Please see the listing and enter arguments or hit enter to pass in null: ");
            string userArguments = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();

            if (userArguments != null)
            {
                userArguments = userArguments.Trim();
            }

            if (string.IsNullOrWhiteSpace(userArguments))
            {
                args = new string[0];
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

            if (!int.TryParse(chapterListing[0], out startPosition))
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
}