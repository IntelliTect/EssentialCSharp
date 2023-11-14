namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_05;

#region INCLUDE
public class Program
{
    #region EXCLUDE
    public static void Main()
    {
        Console.WriteLine(MyMethod());
    }
    #endregion EXCLUDE

    public static bool MyMethod()
    {
        string command = ObtainCommand();
        switch(command)
        {
            case "quit":
                return false;
            // ... omitted, other cases
            default:
                return true;
        }
    }

    #region EXCLUDE
    private static string ObtainCommand()
    {
        return Console.ReadLine() ?? string.Empty;
    }
    #endregion EXCLUDE
}
#endregion INCLUDE
