namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_07;

public class Program
{
    #region INCLUDE
    public static void Main()
    {
        #region HIGHLIGHT
        string GetUserInput(string prompt)
        {
            string? input;
            do
            {
                Console.Write(prompt + ": ");
                input = Console.ReadLine();
            }
            while(string.IsNullOrWhiteSpace(input));
            return input!;
        };
        #endregion HIGHLIGHT
        
        string firstName = GetUserInput("First Name");
        string lastName = GetUserInput("Last Name");
        string email = GetUserInput("Email Address");

        Console.WriteLine($"{firstName} {lastName} <{email}>");
        //...
        #endregion INCLUDE
    }
}
