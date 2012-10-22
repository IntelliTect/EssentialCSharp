namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_22
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
                    "Hi {0}!  You are {1} months old.",
                    firstName, age * 12);
            }
            catch (System.FormatException exception)
            {
                System.Console.WriteLine(
                    "The age entered ,{0}, is not valid.",
                    ageText);
                result = 1;
            }
            catch (System.Exception exception)
            {
                System.Console.WriteLine(
                    "Unexpected error:  {0}", exception.Message);
                result = 1;
            }
            catch
            {
                System.Console.WriteLine(
                    "Unexpected error!");
                result = 1;
            }
            finally
            {
                System.Console.WriteLine("Goodbye {0}",
                    firstName);
            }

            return result;
        }
    }
}
