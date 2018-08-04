namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_21
{
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            DisplayGreeting(
                firstName: "Inigo", lastName: "Montoya");
        }

        public static void DisplayGreeting(
            string firstName,
            string middleName = default(string),
            string lastName = default(string))
        {
            // ...
        }
    }
}
