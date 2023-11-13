namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_03;

#region INCLUDE
using System.Diagnostics;
using System.IO;
using System.Reflection;

public partial class Program
{
    public static void Main(string[] args)
    {
        CommandLineInfo commandLine = new();
        if(!CommandLineHandler.TryParse(
            args, commandLine, out string? errorMessage))
        {
            Console.WriteLine(errorMessage);
            DisplayHelp();
        } 
        else if (commandLine.Help || string.IsNullOrWhiteSpace(commandLine.Out))
        {
            DisplayHelp();
        }
        else
        {
            if(commandLine.Priority !=
                ProcessPriorityClass.Normal)
            {
                // Change thread priority
            }
            #region EXCLUDE
            Console.WriteLine(
                @$"Running {
                    Path.GetFileName(Environment.GetCommandLineArgs()[0])} /Out:{
                        commandLine.Out} /Priority:{
                        commandLine.Priority}");

            #endregion EXCLUDE
        }
    }

    private static void DisplayHelp()
    {
        // Display the command-line help.
        Console.WriteLine(
            "Compress.exe /Out:< file name > /Help "
            + "/Priority:RealTime | High | "
            + "AboveNormal | Normal | BelowNormal | Idle");

    }
}

public partial class Program
{
    private class CommandLineInfo
    {
        public bool Help { get; set; }

        public string? Out { get; set; }

        public ProcessPriorityClass Priority { get; set; }
            = ProcessPriorityClass.Normal;
    }

}

public class CommandLineHandler
{
    public static void Parse(string[] args, object commandLine)
    {
        if (!TryParse(args, commandLine, out string? errorMessage))
        {
            throw new InvalidOperationException(errorMessage);
        }
    }

    public static bool TryParse(string[] args, object commandLine,
        out string? errorMessage)
    {
        bool success = false;
        errorMessage = null;
        foreach(string arg in args)
        {
            string option;
            if(arg[0] == '/' || arg[0] == '-')
            {
                string[] optionParts = arg.Split(
                    new char[] { ':' }, 2);

                // Remove the slash|dash
                option = optionParts[0].Remove(0, 1);
                #region HIGHLIGHT
                PropertyInfo? property =
                    commandLine.GetType().GetProperty(option,
                        BindingFlags.IgnoreCase |
                        BindingFlags.Instance |
                        BindingFlags.Public);
                if(property is not null)
                {
                    if(property.PropertyType == typeof(bool))
                    {
                        // Last parameters for handling indexers
                        property.SetValue(
                            commandLine, true, null);
                        success = true;
                    }
                    else if(
                        property.PropertyType == typeof(string))
                    {
                        property.SetValue(
                            commandLine, optionParts[1], null);
                        success = true;
                    }
                    else if (
                        // property.PropertyType.IsEnum also available
                        property.PropertyType ==
                            typeof(ProcessPriorityClass))
                    {
                        try
                        {
                            property.SetValue(commandLine,
                                Enum.Parse(
                                    typeof(ProcessPriorityClass),
                                    optionParts[1], true),
                                null);
                            success = true;
                        }
                        #endregion HIGHLIGHT
                        catch (ArgumentException)
                        {
                            success = false;
                            errorMessage =
                                $@"The option '{
                                    optionParts[1]
                                    }' is invalid for '{ 
                                    option }'";
                        }
                    }
                    else
                    {
                        success = false;
                        errorMessage = 
                            $@"Data type '{
                                property.PropertyType }' on {
                                commandLine.GetType() } is not supported.";
                    }
                }
                else
                {
                    success = false;
                    errorMessage = 
                       $"Option '{ option }' is not supported.";
                }
            }
        }
        return success;
    }
}
#endregion INCLUDE
