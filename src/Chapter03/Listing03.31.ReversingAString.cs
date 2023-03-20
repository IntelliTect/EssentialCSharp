namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_31;

public class Palindrome
{
    public static void Main()
    {
        #region INCLUDE
        string reverse, palindrome;
        char[] temp;

        Console.Write("Enter a palindrome: ");
        palindrome = Console.ReadLine();

        // Remove spaces and convert to lowercase
        reverse = palindrome.Replace(" ", "");
        reverse = reverse.ToLower();

        #region HIGHLIGHT
        // Convert to an array
        temp = reverse.ToCharArray();
        #endregion HIGHLIGHT

        #region HIGHLIGHT
        // Reverse the array
        Array.Reverse(temp);
        #endregion HIGHLIGHT

        // Convert the array back to a string and
        // check if reverse string is the same
        if (reverse == new string(temp))
        {
            Console.WriteLine(
                $"\"{palindrome}\" is a palindrome.");
        }
        else
        {
            Console.WriteLine(
                $"\"{palindrome}\" is NOT a palindrome.");
        }
        #endregion INCLUDE
    }
}
