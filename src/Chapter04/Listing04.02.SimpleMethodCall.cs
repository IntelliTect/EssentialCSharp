namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_02
{
    public class HeyYou
    {
        public static void Main()
        {
            string firstName;
            string lastName;

            System.Console.Write("Hey you!");

            System.Console.Write("Enter your first name: ");
            firstName = System.Console.ReadLine();

            System.Console.Write("Enter your last name: ");
            lastName = System.Console.ReadLine();

            System.Console.WriteLine(
                $"Your full name is { firstName } { lastName }.");
        }
    }
}
