using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace AddisonWesley.Michaelis.EssentialCSharp.Shared
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string listing;
            IEnumerable<string> arguments = null;
            if (args.Length == 0)
            {
                Console.Write("Enter the listing number to execute (e.g. For Listing 18.1 enter \"18.1\"): ");
                listing = Console.ReadLine();
            }
            else
            {
                listing = args[0];
                arguments = args.Skip(1);
            }

            LaunchMain(listing, arguments);
        }

        private static void LaunchMain(string listing, IEnumerable<string> stringArguments)
        {
            Console.WriteLine();
            Console.WriteLine("____________________________");
            Console.WriteLine();
            ConsoleColor originalColor = Console.ForegroundColor;

            try
            {

                listing = ParseListingName(listing);

                Type target = Assembly.GetExecutingAssembly().GetTypes().First(
                    type => type.FullName.Contains(listing + "."));
                var method = (MethodInfo)target.GetMember("Main").First();

                object[] arguments;
                if (!method.GetParameters().Any())
                {
                    arguments = null;
                }
                else
                {
                    if (stringArguments == null)
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
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                    thread.Join();
                }
                else
                {
                    method.Invoke(null, arguments);
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
            string[] chapterListing = listing.Split('.');
            listing = string.Empty;

            int startPosition;

            if (!int.TryParse(chapterListing[0], out startPosition))
            {
                startPosition = 1;
                listing += chapterListing[0].ToUpper() + ".";
            }
            else
            {
                startPosition = 0;
            }

            for (int index = startPosition; index < chapterListing.Length; index++)
            {
                listing += chapterListing[index].PadLeft(2, '0') + ".";
            }

            listing = listing.Substring(0, listing.Length - 1);
            return listing.Replace('.', '_');
        }
    }
}