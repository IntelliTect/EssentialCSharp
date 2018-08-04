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
            firstName = Console.ReadLine();

            Console.Write("Enter your age: ");
            ageText = Console.ReadLine();
            age = int.Parse(ageText);

            Console.WriteLine(
                $"Hi { firstName }!  You are { age * 12 } months old.");
        }
    }
}
