namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_04
{
    public class Program
    {
        public static void Main()
        {
            string firstName;
            string lastName;
            string fullName;

            System.Console.WriteLine("Hey you!");

            firstName = GetUserInput("Enter your first name: ");
            lastName = GetUserInput("Enter your last name: ");

            fullName = GetFullName(firstName, lastName);

            DisplayGreeting(fullName);
        }

        static string GetUserInput(string prompt)
        {
            System.Console.Write(prompt);
            return System.Console.ReadLine();
        }

        static string GetFullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }

        static void DisplayGreeting(string name)
        {
            System.Console.WriteLine($"Your full name is { name }.");
            return;
        }
    }
}
