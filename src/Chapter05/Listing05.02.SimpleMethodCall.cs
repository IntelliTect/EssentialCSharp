namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_02;

public class HeyYou
{
    #region INCLUDE
    public static void Main()
    {
        string? firstName;
        string? lastName;

        Console.WriteLine("Hey you!");

        Console.Write("Enter your first name: ");
        firstName = Console.ReadLine();

        Console.Write("Enter your last name: ");
        lastName = Console.ReadLine();

        Console.WriteLine(
            $"Your full name is { firstName } { lastName }.");
    }
    #endregion INCLUDE
}
