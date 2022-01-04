namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_02
{
    public class HeyYou
    {
        public static void Main()
        {
            string firstName;
            string lastName;

            System.Console.WriteLine("Hey you!");

            System.Console.Write("Enter your first name: ");
            // TODO: Update listing in Manuscript
            firstName = System.Console.ReadLine() ?? string.Empty;

            System.Console.Write("Enter your last name: ");
            // TODO: Update listing in Manuscript
            lastName = System.Console.ReadLine() ?? string.Empty;

            System.Console.WriteLine(
                $"Your full name is { firstName } { lastName }.");
        }
    }
}
