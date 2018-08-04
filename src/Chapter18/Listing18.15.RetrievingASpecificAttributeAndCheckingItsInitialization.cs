namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_15
{
    using System;
    using System.Reflection;
    using Listing18_14;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            PropertyInfo property =
            typeof(CommandLineInfo).GetProperty("Help");
            CommandLineSwitchAliasAttribute attribute =
                (CommandLineSwitchAliasAttribute)
                    property.GetCustomAttributes(
                    typeof(CommandLineSwitchAliasAttribute), false).ElementAt(0);
            if(attribute.Alias == "?")
            {
                Console.WriteLine("Help(?)");
            };
        }
    }
}