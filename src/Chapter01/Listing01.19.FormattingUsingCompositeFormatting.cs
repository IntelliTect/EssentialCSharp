namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_19;

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

        #region HIGHLIGHT
        Console.Write("Enter your last name: ");
        lastName = Console.ReadLine();
        #endregion HIGHLIGHT

        Console.WriteLine(
            "Your full name is {0} {1}.", firstName, lastName);
    }
}
#endregion INCLUDE
