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
        
        string firstName = GetUserInput("名字");
        string lastName = GetUserInput("姓氏");
        string email = GetUserInput("电子邮件地址");

        Console.WriteLine($"{firstName} {lastName} <{email}>");
        //...
        #endregion INCLUDE
    }
}
