namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_19
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
            firstName = Console.ReadLine();

            Console.Write("Enter your age: ");
            ageText = Console.ReadLine();
            age = int.Parse(ageText);

            Console.WriteLine(
                "Hi {0}!  You are {1} months old.",
                firstName, age * 12);
        }
    }
}
