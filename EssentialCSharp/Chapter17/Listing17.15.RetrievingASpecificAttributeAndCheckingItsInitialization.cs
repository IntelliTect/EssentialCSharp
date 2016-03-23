namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_14
{
    using System;
    using System.Reflection;
    using Listing17_13;

    public class Program
    {
        public static void Main()
        {
            PropertyInfo property =
            typeof(CommandLineInfo).GetProperty("Help");
            CommandLineSwitchAliasAttribute attribute =
                (CommandLineSwitchAliasAttribute)
                    property.GetCustomAttributes(
                    typeof(CommandLineSwitchAliasAttribute), false)[0];
            if(attribute.Alias == "?")
            {
                Console.WriteLine("Help(?)");
            };
        }
    }
}