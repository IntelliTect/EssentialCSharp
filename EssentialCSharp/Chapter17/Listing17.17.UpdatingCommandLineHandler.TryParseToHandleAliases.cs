namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_16
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;
    using Listing17_15;

    public class CommandLineHandler
    {
        // ...
        public static bool TryParse(
            string[] args, object commandLine,
            out string errorMessage)
        {
            bool success = false;
            errorMessage = null;

            Dictionary<string, PropertyInfo> options =
                CommandLineSwitchAliasAttribute.GetSwitches(
                    commandLine);

            foreach(string arg in args)
            {
                PropertyInfo property;
                string option;
                if(arg[0] == '/' || arg[0] == '-')
                {
                    string[] optionParts = arg.Split(
                        new char[] { ':' }, 2);
                    option = optionParts[0].Remove(0, 1).ToLower();

                    if(options.TryGetValue(option, out property))
                    {
                        success = SetOption(
                            commandLine, property,
                            optionParts, ref errorMessage);
                    }
                    else
                    {
                        success = false;
                        errorMessage = 
                            $"Option '{option}' is not supported.";
                    }
                }
            }
            return success;
        }

        private static bool SetOption(
            object commandLine, PropertyInfo property,
            string[] optionParts, ref string errorMessage)
        {
            bool success;

            if(property.PropertyType == typeof(bool))
            {
                // Last parameters for handling indexers
                property.SetValue(
                    commandLine, true, null);
                success = true;
            }
            else
            {

                if((optionParts.Length < 2)
                    || optionParts[1] == ""
                    || optionParts[1] == ":")
                {
                    // No setting was provided for the switch.
                    success = false;
                    errorMessage = string.Format(
                        "You must specify the value for the {0} option.",
                        property.Name);
                }
                else if(
                    property.PropertyType == typeof(string))
                {
                    property.SetValue(
                        commandLine, optionParts[1], null);
                    success = true;
                }
                else if(property.PropertyType.IsEnum)
                {
                    success = TryParseEnumSwitch(
                        commandLine, optionParts,
                        property, ref errorMessage);
                }
                else
                {
                    success = false;
                    errorMessage = string.Format(
                        "Data type '{0}' on {1} is not supported.",
                        property.PropertyType.ToString(),
                        commandLine.GetType().ToString());
                }
            }
            return success;
        }

        private static bool TryParseEnumSwitch(object commandLine, string[] optionParts, PropertyInfo property, ref string errorMessage)
        {
            throw new NotImplementedException();
        }
    }
}
