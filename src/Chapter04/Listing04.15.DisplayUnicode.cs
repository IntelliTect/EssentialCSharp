namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_15
{
    public class Program
    {
        public static void Main()
        {
            char current;
            int unicodeValue;

            // Set the initial value of current
            current = 'z';

            do
            {
                // Retrieve the Unicode value of current
                unicodeValue = current;
                System.Console.Write($"{current}={unicodeValue}\t");

                // Proceed to the previous letter in the alphabet
                current--;
            }
            while(current >= 'a');
        }
    }
}
