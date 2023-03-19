namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_20;

public class Program
{
    public static void Main()
    {
        string firstName;
        string lastName;

        Console.WriteLine("Hey you!");

        Console.Write("Enter your first name: ");
        firstName = Console.ReadLine();

        Console.Write("Enter your last name: ");
        lastName = Console.ReadLine();
        #region INCLUDE
        Console.WriteLine("Your full name is {1}, {0}.", firstName, lastName);
        #endregion INCLUDE
    }
}
