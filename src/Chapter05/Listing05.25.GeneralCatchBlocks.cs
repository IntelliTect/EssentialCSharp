#pragma warning disable CS1058 // A previous catch clause already catches all exceptions
#pragma warning disable CS0168 // Variable is declared but never used
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_25
{
    public class ExceptionHandling
    {
        public static int Main()
        {
            string firstName;
            string ageText;
            int age;
            int result = 0;

            System.Console.Write("Enter your first name: ");
            firstName = System.Console.ReadLine();

            System.Console.Write("Enter your age: ");
            ageText = System.Console.ReadLine();

            try
            {
                age = int.Parse(ageText);
                System.Console.WriteLine(
                    $"Hi { firstName }!  You are { age * 12 } months old.");
            }
            catch(System.FormatException exception)
            {
                System.Console.WriteLine(
                    $"The age entered ,{ageText}, is not valid.");
                result = 1;
            }
            catch(System.Exception exception)
            {
                System.Console.WriteLine(
                    $"Unexpected error:  { exception.Message }");
                result = 1;
            }
            catch
            {
                System.Console.WriteLine("Unexpected error!");
                result = 1;
            }
            finally
            {
                System.Console.WriteLine($"Goodbye { firstName }");
            }

            return result;
        }
    }
}
