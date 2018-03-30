namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_24
{
    using System;

    public class ExceptionHandling
    {
        public static int Main()
        {
            string firstName;
            string ageText;
            int age;
            int result = 0;

            Console.Write("Enter your first name: ");
            firstName = Console.ReadLine();

            Console.Write("Enter your age: ");
            ageText = Console.ReadLine();

            try
            {
                age = int.Parse(ageText);
                Console.WriteLine(
                    $"Hi { firstName }! You are { age * 12 } months old.");
            }
            finally
            {
                Console.WriteLine($"Goodbye { firstName }");
            }

            return result;
        }
    }
}