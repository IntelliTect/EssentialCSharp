namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_22
{
    using System;

    public class ExceptionHandling
    {
        public static void Main()
        {
            string firstName;
            string ageText;
            int age;

            Console.WriteLine("Hey you!");

            Console.Write("Enter your first name: ");
            // TODO: Update listing in Manuscript
            firstName = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter your age: ");
            // TODO: Update listing in Manuscript
            ageText = Console.ReadLine() ?? string.Empty;
            age = int.Parse(ageText);

            Console.WriteLine(
                $"Hi { firstName }!  You are { age * 12 } months old.");
        }
    }
}
