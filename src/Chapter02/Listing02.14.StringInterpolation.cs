namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_14;

public class Program
{
    public static void Main()
    {
        string firstName;
        string lastName;

        Console.WriteLine("Enter your first name: ");
        firstName = Console.ReadLine();

        Console.WriteLine("Enter your last name: ");

        lastName = Console.ReadLine();

        #region INCLUDE
        Console.WriteLine($"Your full name is {lastName} {firstName}.");
        #endregion INCLUDE
    }
}
