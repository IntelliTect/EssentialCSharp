namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_18
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;
    using Listing18_17;

    public class CommandLineHandler
    {
        // ...
        public static bool TryParse(
            string[] args, object commandLine,
            out string? errorMessage)
        {
            bool success = false;
            errorMessage = null;

            Dictionary<string, PropertyInfo> options =
                CommandLineSwitchAliasAttribute.GetSwitches(
                    commandLine);

            foreach(string arg in args)
            {
                string option;
                if(arg[0] == '/' || arg[0] == '-')
                {
                    string[] optionParts = arg.Split(
                        new char[] { ':' }, 2);
                    option = optionParts[0].Remove(0, 1).ToLower();

                    if(options.TryGetValue(option, out PropertyInfo? property))
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
            string[] optionParts, ref string? errorMessage)
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
                    || optionParts[1] == "")
                {
                    // No setting was provided for the switch.
                    success = false;
                    errorMessage =
                         $"You must specify the value for the { property.Name } option.";
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

// Justification: Not fully implemented.
#pragma warning disable IDE0060 // Remove unused parameter
        private static bool TryParseEnumSwitch(
            object commandLine, string[] optionParts, PropertyInfo property, ref string? errorMessage)
        {
            throw new NotImplementedException();
        }
#pragma warning restore IDE0060 // Remove unused parameter
    }
}
