namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_18
{
    #region INCLUDE
    public class Uppercase
    {
        public static void Main()
        {
            string text, uppercase;

            System.Console.Write("Enter text: ");
            text = System.Console.ReadLine();

            // Return a new string in uppercase
            #region HIGHLIGHT
            uppercase = text.ToUpper();
            #endregion HIGHLIGHT

            System.Console.WriteLine(uppercase);
        }
    }
    #endregion INCLUDE
}
