namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_15
{
    #region INCLUDE
    // The using directives allow you to drop the namespace
    #region HIGHLIGHT
    using static System.Console;
    #endregion HIGHLIGHT
    public class HeyYou
    {
        public static void Main()
        {
            string firstName;
            string lastName;

            #region HIGHLIGHT
            WriteLine("Hey you!");
            #endregion HIGHLIGHT

            #region HIGHLIGHT
            Write("Enter your first name: ");
            firstName = ReadLine();
            #endregion HIGHLIGHT

            Write("Enter your last name: ");
            #region HIGHLIGHT
            lastName = ReadLine();
            #endregion HIGHLIGHT

            #region HIGHLIGHT
            WriteLine(
            #endregion HIGHLIGHT
              $"Your full name is {firstName} {lastName}.");
        }
    }
    #endregion INCLUDE
}
