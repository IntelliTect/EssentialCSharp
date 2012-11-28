namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_21
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
                    "Hi {0}!  You are {1} months old.",
                    firstName, age * 12);
            }
            finally
            {
                Console.WriteLine("Goodbye {0}",
                    firstName);
            }

            return result;
        }
    }
}