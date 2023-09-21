namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_17;

using AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_16;
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
