namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_14
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;

    public class CommandLineSwitchRequiredAttribute : Attribute
    {
        public static string[] GetMissingRequiredOptions(
            object commandLine)
        {
            List<string> missingOptions = new List<string>();
            PropertyInfo[] properties =
                commandLine.GetType().GetProperties();

            foreach(PropertyInfo property in properties)
            {
                Attribute[] attributes =
                     (Attribute[])property.GetCustomAttributes(
                        typeof(CommandLineSwitchRequiredAttribute),
                        false);
                if((attributes.Length > 0) &&
                    (property.GetValue(commandLine, null) == null))
                {
                    missingOptions.Add(property.Name);
                }
            }
            return missingOptions.ToArray();
        }
    }
}
