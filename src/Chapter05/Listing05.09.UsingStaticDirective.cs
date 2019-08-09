namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_09
{
    using static System.Console;

    public class HeyYou
    {
        public static void Main()
        {
            string firstName;
            string lastName;

            WriteLine("Hey you!");

            Write("Enter your first name: ");

            firstName = ReadLine();
            Write("Enter your last name: ");
            lastName = ReadLine();
            WriteLine(
                $"Your full name is { firstName } { lastName }.");
        }
    }

}