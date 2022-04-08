namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_15
{
    #region INCLUDE
    #region HIGHLIGHT
    using static System.Console;
    #endregion
    public class HeyYou
    {
        public static void Main()
        {
            string firstName;
            string lastName;

            #region HIGHLIGHT
            WriteLine("Hey you!");
            #endregion

            #region HIGHLIGHT
            Write("Enter your first name: ");
            firstName = ReadLine();
            #endregion

            Write("Enter your last name: ");
            #region HIGHLIGHT
            lastName = ReadLine();
            #endregion

            #region HIGHLIGHT
            WriteLine(
            #endregion
              $"Your full name is {firstName} {lastName}.");
        }
    }
    #endregion
}
