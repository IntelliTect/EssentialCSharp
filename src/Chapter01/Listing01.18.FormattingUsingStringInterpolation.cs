namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_18;

#region INCLUDE
public class HeyYou
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

        Console.WriteLine(
        #region HIGHLIGHT
            $"Your full name is { firstName } { lastName }.");
        #endregion HIGHLIGHT
    }
}
#endregion INCLUDE
