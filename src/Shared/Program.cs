#nullable enable 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;

namespace AddisonWesley.Michaelis.EssentialCSharp.Shared
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input;
            IEnumerable<string> stringArguments = new string[0];
            if (args.Length == 0)
            {
                Console.Write("Enter the listing number to execute (e.g. For Listing 18.1 enter \"18.1\"): ");
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
                System.Diagnostics.Debugger.Break();
                string chapterName = "";
                string listing = ParseListingName(input, out chapterName);

                var assembly = Assembly.Load(new AssemblyName(chapterName)); // Throws System.IO.FileNotFound exception if assembly does not exist.

                Type? target = assembly.GetTypes().FirstOrDefault(type => type.FullName.Contains(listing + "."));
                if(target == null)
                {
                    throw new InvalidOperationException($"There is no listing '{input}'.");
                }
                var method = (MethodInfo)target.GetMember("Main").First();

                object[]? arguments;
                if (!method.GetParameters().Any())
                {
                    arguments = null;  // If there are no parameters to the method, the arguments parameter should be null.
                }
                else
                {
                    if (stringArguments.Count()==0)
                    {
                        arguments = new object[] { GetArguments() };
                    }
                    else
                    {
                        arguments = new object[] { stringArguments.ToArray() };
                    }
                }
                if (method.GetCustomAttributes(typeof(STAThreadAttribute), false).Any())
                {
                    Thread thread = new Thread(() => method.Invoke(null, arguments));
                    //thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                    thread.Join();
                }
                else
                {
                    method.Invoke(null, arguments);
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
                    Console.WriteLine(string.Format("Listing {0} threw an exception of type {1}.", input, exception.GetType()));
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

        private static string ParseListingName(string listing, out string chapterName)
        {
            var appendices = new List<string> { "A", "B", "C", "D" };

            chapterName = "";

            string[] chapterListing = listing.Split('.');
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

            int.TryParse(chapterListing[0], out var chapterNum);

            return listing.Replace('.', '_').Replace($"-{chapterNum}_", "To");
        }
    }
}
