namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_06
{
    public class Program
    {
        static string GetUserInput(string prompt)
        {
            System.Console.Write(prompt);
            return System.Console.ReadLine();
        }
        static (string First, string Last) GetName()
        {
            string firstName, lastName;
            firstName = GetUserInput("Enter your first name: ");
            lastName = GetUserInput("Enter your last name: ");
            return (firstName, lastName);
        }
        static public void Main()
        {
            (string First, string Last) name = GetName();
            System.Console.WriteLine($"Hello { name.First } { name.Last }!");
        }
    }
}
