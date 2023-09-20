namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_13;

#region INCLUDE
using static System.Console;

public class HeyYou
{
    public static void Main()
    {
        string firstName;
        string lastName;

        WriteLine("Hey you!");

        Write("Enter your first name: ");
        firstName = ReadLine() ?? string.Empty;

        Write("Enter your last name: ");
        lastName = ReadLine() ?? string.Empty;

        WriteLine(
            $"Your full name is { firstName } { lastName }.");
    }
}
#endregion INCLUDE
