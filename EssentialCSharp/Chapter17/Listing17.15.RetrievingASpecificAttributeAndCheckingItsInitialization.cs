namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_14
{
    using System;
    using System.Reflection;
    using Listing17_13;
    using System.Linq;

    public class Program
    {
        public static void ChapterMain()
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