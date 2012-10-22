namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_02
{
    class HeyYou
    {
        static void Main()
        {
            string firstName;
            string lastName;

            System.Console.Write("Enter your first name: ");

            firstName = System.Console.ReadLine();

            System.Console.Write("Enter your last name: ");
            lastName = System.Console.ReadLine();

            System.Console.WriteLine("Your full name is {0} {1}.",
                firstName, lastName);
        }
    }
}
