namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_17;

#region INCLUDE
using System.Reflection;
using System.Collections.Generic;

public class CommandLineSwitchAliasAttribute : Attribute
{
    public CommandLineSwitchAliasAttribute(string alias)
    {
        Alias = alias;
    }

    public string Alias { get; set; }

    public static Dictionary<string, PropertyInfo> GetSwitches(
        object commandLine)
    {
        PropertyInfo[] properties;
        Dictionary<string, PropertyInfo> options = new();

        properties = commandLine.GetType().GetProperties(
            BindingFlags.Public | BindingFlags.Instance);
        foreach(PropertyInfo property in properties)
        {
            options.Add(property.Name, property);
            #region HIGHLIGHT
            foreach (CommandLineSwitchAliasAttribute attribute in
                property.GetCustomAttributes(
                typeof(CommandLineSwitchAliasAttribute), false))
            #endregion HIGHLIGHT
            {
                options.Add(attribute.Alias.ToLower(), property);
            }
        }
        return options;
    }
}
#endregion INCLUDE
