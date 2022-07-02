namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_16
{
    using AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_15;
    using System;
    using System.Linq;
    using System.Reflection;

    public class Program
    {
        public static void Main()
        {
            PropertyInfo property =
            typeof(CommandLineInfo).GetProperty("Help")!;
            CommandLineSwitchAliasAttribute attribute =
                (CommandLineSwitchAliasAttribute)
                    property.GetCustomAttributes(
                    typeof(CommandLineSwitchAliasAttribute), false).ElementAt(0);
            if (attribute.Alias == "?")
            {
                Console.WriteLine("Help(?)");
            };
        }
    }
}
