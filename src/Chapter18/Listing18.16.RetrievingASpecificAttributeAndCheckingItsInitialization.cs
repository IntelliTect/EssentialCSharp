namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_16
{
    using System;
    using System.Reflection;
    using System.Linq;
    using AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_15;

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
            if(attribute.Alias == "?")
            {
                Console.WriteLine("Help(?)");
            };
        }
    }
}
