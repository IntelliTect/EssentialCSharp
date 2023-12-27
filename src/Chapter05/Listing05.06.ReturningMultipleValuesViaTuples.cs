namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_06;

#region INCLUDE
public class Program
{
    static string GetUserInput(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine() ?? string.Empty;
    }
    #region HIGHLIGHT
    static (string First, string Last) GetName()
    #endregion HIGHLIGHT
    {
        string firstName, lastName;
        firstName = GetUserInput("�������������: ");
        lastName = GetUserInput("�������������: ");         
        return (firstName, lastName);
    }
    public static void Main()
    {
        #region HIGHLIGHT
        (string First, string Last) name = GetName();
        #endregion HIGHLIGHT
        Console.WriteLine($"��ã�{ name.First } { name.Last }��");
    }
}
#endregion INCLUDE
