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
            var assembly = Assembly.GetEntryAssembly();

            string regexMatch = Regex.Match(assembly.GetName().Name, "\\d{1,2}").Value;

            int chapterNumber = int.Parse(regexMatch);

            string listing;
            IEnumerable<string> stringArguments = null;
            if (args.Length == 0)
            {
                Console.Write($"Enter the listing number to execute (e.g. For Listing {chapterNumber}.1 enter \"{chapterNumber}.1\"): ");
                listing = Console.ReadLine();
            }
            else
            {
                listing = args[0];
                stringArguments = args.Skip(1);
            }

            Console.WriteLine();
            Console.WriteLine("____________________________");
            Console.WriteLine();
            ConsoleColor originalColor = Console.ForegroundColor;

            try
            {
                listing = ParseListingName(listing);

                Regex reg = new Regex($"{listing}\\.+");
                Type target = assembly.GetTypes().First(type =>
                {
                    return reg.IsMatch(type.FullName);
                });
                MethodInfo method = target.GetMethods().First();

                string[] arguments;
                if (!method.GetParameters().Any())
                {
                    arguments = null;
                }
                else
                {
                    if (stringArguments == null)
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
                    object result = "";
                    
                    Thread thread = new Thread(() => result = method.Invoke(null, arguments));
                    //thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                    thread.Join();
                    
                    if (!(method.ReturnType == typeof(void)))
                    {
                        Console.WriteLine($"Result: {result}");
                    }
                }
                else
                {
                    var result = method.Invoke(null, arguments);

                    if (!(method.ReturnType == typeof(void)))
                    {
                        Console.WriteLine($"Result: {result}");
                    }
                }
            }
            catch (TargetParameterCountException exception)
            {
                throw new InvalidOperationException(
                    string.Format("Fatal Error invoking Listing {0}.\n", listing),
                        exception);
            }
            catch (InvalidOperationException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("----Exception----");
                Console.WriteLine(string.Format("Error, could not run the Listing '{0}', please make sure it is a valid listing and in the correct format", listing));
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("----Exception----");
                if (exception.InnerException != null)
                {
                    // Invoke ExceptionDispatchInfo using reflection because it doesn't 
                    // exist in .NET 4.0 or earlier and we want to maintain compatibility
                    // while still taking advantage of it if it is available.
                    Type exceptionDispatchInfoType =
                            Type.GetType(
                                "System.Runtime.ExceptionServices.ExceptionDispatchInfo");
                    if (exceptionDispatchInfoType != null)
                    {
                        dynamic exceptionDispatchInfo = exceptionDispatchInfoType.GetMethod("Capture")
                            .Invoke(exceptionDispatchInfoType, new object[] { exception.InnerException });
                        exceptionDispatchInfo.Throw();
                    }
                    else
                        throw exception.InnerException;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(string.Format("Listing {0} threw an exception of type {1}.", listing, exception.GetType()));
                }
            }
            finally
            {
                Console.ForegroundColor = originalColor;

                Console.WriteLine();
                Console.WriteLine("____________________________");
                Console.WriteLine("End of Listing " + listing);
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
                chapterName = "Chapter" + (appendices.Contains(chapterListing[0].ToUpper()) ? "App" : "") + chapterListing[0];
            }
            else
            {
                startPosition = 0;
            }

            for (int index = startPosition; index < chapterListing.Length; index++)
            {
                if (index == startPosition && string.IsNullOrEmpty(chapterName)) chapterName = "Chapter" + chapterListing[index].PadLeft(2, '0');
                listing += chapterListing[index].PadLeft(2, '0') 
                           + ((index+1 != chapterListing.Length) ? "." : "");
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
