namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_12
{
    using static System.Console;
    class HeyYou
    {
        static void Main()
        {
            string firstName;
            string lastName;

            WriteLine("Hey you!");

            Write("Enter your first name: ");
            firstName = ReadLine();

            Write("Enter your last name: ");
            lastName = ReadLine();

            WriteLine(
              $"Your full name is {firstName} {lastName}.");
        }
    }
}
