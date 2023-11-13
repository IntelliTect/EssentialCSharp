namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_14;

#region INCLUDE
using System.Reflection;
using System.Collections.Generic;

public class CommandLineSwitchRequiredAttribute : Attribute
{
    public static string[] GetMissingRequiredOptions(
        object commandLine)
    {
        List<string> missingOptions = new();
        PropertyInfo[] properties =
            commandLine.GetType().GetProperties();

        foreach(PropertyInfo property in properties)
        {
            Attribute[] attributes =
                 (Attribute[])property.GetCustomAttributes(
                    typeof(CommandLineSwitchRequiredAttribute),
                    false);
            if (attributes.Length > 0 &&
                property.GetValue(commandLine, null) is null)
            {
                missingOptions.Add(property.Name);
            }
        }
        return missingOptions.ToArray();
    }
}
#endregion INCLUDE
