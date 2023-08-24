namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_16;

using AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_15;
using System.Reflection;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        PropertyInfo property =
            typeof(CommandLineInfo).GetProperty("Help")!;
        CommandLineSwitchAliasAttribute? attribute =
            (CommandLineSwitchAliasAttribute?)
                property.GetCustomAttribute(
                typeof(CommandLineSwitchAliasAttribute), false);
        if(attribute?.Alias == "?")
        {
            Console.WriteLine("Help(?)");
        };
        #endregion INCLUDE
    }
}
