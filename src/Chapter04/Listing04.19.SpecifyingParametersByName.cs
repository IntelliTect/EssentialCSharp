namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_18
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
