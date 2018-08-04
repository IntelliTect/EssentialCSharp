namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_16
{
    using System;
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
            PropertyInfo[] properties = null;
            Dictionary<string, PropertyInfo> options =
                new Dictionary<string, PropertyInfo>();

            properties = commandLine.GetType().GetProperties(
                BindingFlags.Public | BindingFlags.NonPublic |
                BindingFlags.Instance);
            foreach(PropertyInfo property in properties)
            {
                options.Add(property.Name.ToLower(), property);
                foreach(CommandLineSwitchAliasAttribute attribute in
                    property.GetCustomAttributes(
                    typeof(CommandLineSwitchAliasAttribute), false))
                {
                    options.Add(attribute.Alias.ToLower(), property);
                }
            }
            return options;
        }
    }
}
