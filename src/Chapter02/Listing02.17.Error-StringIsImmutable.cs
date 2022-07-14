namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_17
{
    #region INCLUDE
    public class Uppercase
    {
        public static void Main()
        {
            string text;

            System.Console.Write("Enter text: ");
            text = System.Console.ReadLine();

            #region HIGHLIGHT
            // UNEXPECTED: Does not convert text to uppercase
            text.ToUpper();
            #endregion HIGHLIGHT

            System.Console.WriteLine(text);
        }
    }
    #endregion INCLUDE
}