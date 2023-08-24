namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_07;

public class Program
{
    #region INCLUDE
    public static void Main()
    {
        #region HIGHLIGHT
        string GetUserInput()
        {
            string? input;
            do
            {
                input = Console.ReadLine();
            }
            while(!string.IsNullOrWhiteSpace(input));
            return input!;
        };
        #endregion HIGHLIGHT
        
        string firstName = GetUserInput();
        string lastName = GetUserInput();
        string email = GetUserInput();

        Console.WriteLine($"{firstName} {lastName} <{email}>");
        //...
        #endregion INCLUDE
    }
}
