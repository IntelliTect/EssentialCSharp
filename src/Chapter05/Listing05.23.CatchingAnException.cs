namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_23
{
    using System;

    public class ExceptionHandling
    {
        public static int Main(string[] args)
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
            catch(FormatException)
            {
                Console.WriteLine(
                    $"The age entered, { ageText }, is not valid."); 
                result = 1;
            }
            catch(Exception exception)
            {
                Console.WriteLine(
                    $"Unexpected error:  { exception.Message }");
                result = 1;
            }
            finally
            {
                Console.WriteLine($"Goodbye { firstName }");
            }

            return result;
        }
    }
}
