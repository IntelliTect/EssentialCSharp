namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_19;
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
        Console.WriteLine(
            $"""Hello, I'm {firstName}. {firstName} {lastName}""");
        #endregion INCLUDE
    }
}
