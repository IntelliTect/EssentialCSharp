namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_56;

using System;

#region INCLUDE
// CommandLine is nested within program
#region HIGHLIGHT
public class Program
{
    // Define a nested class for processing the command line
    private class CommandLine
    {
#endregion HIGHLIGHT
        public CommandLine(string[] arguments)
        {
            for (int argumentCounter = 0;
                argumentCounter < arguments.Length;
                argumentCounter++)
            {
                _ = argumentCounter switch
                {
                    0 => Action = arguments[0].ToLower(),
                    1 => Id = arguments[1],
                    2 => FirstName = arguments[2],
                    3 => LastName = arguments[3],
                    _ => throw new ArgumentException(
                        $"Unexpected argument " +
                        $"'{arguments[argumentCounter]}'")
                };
            }
        }
        public string? Action { get; }
        public string? Id { get; }
        public string? FirstName { get; }
        public string? LastName { get; }
    }

    public static void Main(string[] args)
    {
        #region HIGHLIGHT
        CommandLine commandLine = new(args);
        #endregion HIGHLIGHT

        // Error handling intentionally missing for elucidation.

        switch (commandLine.Action)
        {
            case "new":
                // Create a new employee
                #region EXCLUDE
                Console.WriteLine("'Creating' a new Employee.");
                #endregion EXCLUDE
                break;
            case "update":
                // Update an existing employee's data
                #region EXCLUDE
                Console.WriteLine("'Updating' a new Employee.");
                #endregion EXCLUDE
                break;
            case "delete":
                // Remove an existing employee's file
                #region EXCLUDE
                Console.WriteLine("'Removing' a new Employee.");
                #endregion EXCLUDE
                break;
            default:
                Console.WriteLine(
                    "Employee.exe " +
                    "new|update|delete " +
                    "<id> [firstname] [lastname]");
                break;
        }
    }
}
#endregion INCLUDE
