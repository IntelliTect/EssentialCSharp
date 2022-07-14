namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_17
{
    #region INCLUDE
    public class HeyYou
    {
        public static void Main()
        {
            string firstName;
            string lastName;

            System.Console.WriteLine("Hey you!");

            System.Console.Write("Enter your first name: ");
            firstName = System.Console.ReadLine();

            #region HIGHLIGHT
            System.Console.Write("Enter your last name: ");
            lastName = System.Console.ReadLine();
            #endregion HIGHLIGHT

            System.Console.WriteLine(
                "Your full name is {0} {1}.", firstName, lastName);
        }
    }
    #endregion INCLUDE
}
