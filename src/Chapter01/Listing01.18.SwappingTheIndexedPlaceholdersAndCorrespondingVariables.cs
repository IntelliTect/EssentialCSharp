namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_18
{
    public class Program
    {
        public static void Main()
        {
            string firstName;
            string lastName;

            System.Console.WriteLine("Hey you!");

            System.Console.Write("Enter your first name: ");
            firstName = System.Console.ReadLine();

            System.Console.Write("Enter your last name: ");
            lastName = System.Console.ReadLine();

            System.Console.WriteLine("Your full name is {1}, {0}.", firstName, lastName);
        }
    }
}
