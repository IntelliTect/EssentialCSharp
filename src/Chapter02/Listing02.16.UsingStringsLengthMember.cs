namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_16
{
    #region INCLUDE
    public class PalindromeLength
    {
        public static void Main()
        {
            string palindrome;

            System.Console.Write("Enter a palindrome: ");
            palindrome = System.Console.ReadLine();

            System.Console.WriteLine(
                $"The palindrome \"{palindrome}\" is"
            #region HIGHLIGHT
                + $" {palindrome.Length} characters.");
            #endregion HIGHLIGHT
        }
    }
    #endregion INCLUDE
}
