namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_20
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
            catch(FormatException)
            {
                Console.WriteLine(
                    "The age entered, {0}, is not valid.",
                    ageText);
                result = 1;
            }
            catch(Exception exception)
            {
                Console.WriteLine(
                    "Unexpected error:  {0}", exception.Message);
                result = 1;
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
