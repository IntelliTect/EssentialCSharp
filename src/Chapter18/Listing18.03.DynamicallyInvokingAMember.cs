namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_03
{
    using System;
    using System.Diagnostics;
    using System.Reflection;

    public partial class Program
    {
        public static void Main(string[] args)
        {
            string errorMessage;
            CommandLineInfo commandLine = new CommandLineInfo();
            if(!CommandLineHandler.TryParse(
                args, commandLine, out errorMessage))
            {
                Console.WriteLine(errorMessage);
                DisplayHelp();
            }

            if(commandLine.Help)
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

            }
            // ...
        }

        private static void DisplayHelp()
        {
            // Display the command-line help.
            Console.WriteLine(
                "Compress.exe / Out:< file name > / Help \n"
                + "/ Priority:RealTime | High | "
                + "AboveNormal | Normal | BelowNormal | Idle");

        }
    }

    public partial class Program
    {
        private class CommandLineInfo
        {
            public bool Help { get; set; }

            public string Out { get; set; }

            public ProcessPriorityClass Priority { get; set; }
                = ProcessPriorityClass.Normal;
        }

    }

    public class CommandLineHandler
    {
        public static void Parse(string[] args, object commandLine)
        {
            string errorMessage;
            if(!TryParse(args, commandLine, out errorMessage))
            {
                throw new Exception(errorMessage);
            }
        }

        public static bool TryParse(string[] args, object commandLine,
            out string errorMessage)
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
                    PropertyInfo property =
                        commandLine.GetType().GetProperty(option,
                            BindingFlags.IgnoreCase |
                            BindingFlags.Instance |
                            BindingFlags.Public);
                    if(property != null)
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
                        else if(property.PropertyType.GetTypeInfo().IsEnum)
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
                            catch(ArgumentException)
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
                                    property.PropertyType.ToString()
                                    }' on {
                                    commandLine.GetType().ToString()
                                    } is not supported.";
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
}