namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_19
{
    public class Program
    {
        public static void Main()
        {
            string firstName; //Variable for storing the first name
            string lastName; //Variable for storing the last name

            System.Console.WriteLine("Hey you!");

            System.Console.Write /* No new line */ (
                "Enter your first name: ");
            firstName = System.Console.ReadLine();

            System.Console.Write /* No new line */ (
                "Enter your last name: ");
            lastName = System.Console.ReadLine();

            /* Display a greeting to the console 
              using composite fomatting. */

            System.Console.WriteLine("Your full name is {1}, {0}.", 
                firstName, lastName);
            // This is the end
            // of the program listing
        }
    }
}