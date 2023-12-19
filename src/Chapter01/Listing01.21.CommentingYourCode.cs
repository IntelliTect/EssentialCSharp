namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_21;

#region INCLUDE
public class CommentSamples
{
    public static void Main()
    {
        string firstName; // Variable for storing the first name
        string lastName;  // Variable for storing the last name

        Console.WriteLine("Hey you!");

        Console.Write /* No new line */ ("Enter your first name: ");
        firstName = Console.ReadLine();

        Console.Write /* No new line */ ("Enter your last name: ");
        lastName = Console.ReadLine();

        /* Display a greeting to the console 
          using string interpolation formatting. */

        Console.WriteLine($"Your full name is {firstName} {lastName}.");
        // This is the end
        // of the program listing
    }
}
#endregion INCLUDE
