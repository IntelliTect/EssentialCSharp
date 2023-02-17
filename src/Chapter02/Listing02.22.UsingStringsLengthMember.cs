namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_22;
#region INCLUDE
public class PalindromeLength
{
    public static void Main()
    {
        string palindrome;

        Console.Write("Enter a palindrome: ");
        palindrome = Console.ReadLine();

        Console.WriteLine(
            $"The palindrome \"{palindrome}\" is"
        #region HIGHLIGHT
            + $" {palindrome.Length} characters.");
        #endregion HIGHLIGHT
    }
}
#endregion INCLUDE