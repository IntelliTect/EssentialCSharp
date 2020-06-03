namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_32
{
    public class Palindrome
    {
        public static void Main()
        {
            string reverse, palindrome;
            char[] temp;

            System.Console.Write("Enter a palindrome: ");
            palindrome = System.Console.ReadLine();

            // Remove spaces and convert to lowercase
            reverse = palindrome.Replace(" ", "");
            reverse = reverse.ToLower();

            // Convert to an array
            temp = reverse.ToCharArray();

            // Reverse the array
            System.Array.Reverse(temp);

            // Convert the array back to a string and
            // check if reverse string is the same
            if(reverse == new string(temp))
            {
                System.Console.WriteLine(
                    $"\"{palindrome}\" is a palindrome.");
            }
            else
            {
                System.Console.WriteLine(
                    $"\"{palindrome}\" is NOT a palindrome.");
            }
        }
    }
}
