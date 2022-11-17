namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_18
{
    public class Uppercase
    {
        public static void Main()
        {
            #region INCLUDE
            Console.Write("Enter text: ");
            string text = Console.ReadLine();

            #region HIGHLIGHT
            // UNEXPECTED: Does not convert text to uppercase
            text.ToUpper();
            #endregion HIGHLIGHT

            Console.WriteLine(text);
            #endregion INCLUDE
        }
    }
}
