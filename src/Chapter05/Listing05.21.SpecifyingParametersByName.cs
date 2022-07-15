namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_21
{
    #region INCLUDE
    public class Program
    {
        public static void Main()
        {
            #region HIGHLIGHT
            DisplayGreeting(
                firstName: "Inigo", lastName: "Montoya");
            #endregion HIGHLIGHT
        }

        public static void DisplayGreeting(
            string firstName,
            string? middleName = null,
            string? lastName = null
            )
        {
            // ...
        }
    }
    #endregion INCLUDE
}
