namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_15
{ 
    public class Program
    { 
        public static void Main()
        {
            char current;
            int unicodeValue;

            // Set the initial value of current.
            current = 'z';

            do
            {
                // Retrieve the Unicode value of current.
                unicodeValue = current;
                System.Console.Write("{0}={1}\t", current, unicodeValue);

                // Proceed to the previous letter in the alphabet;
                current--;
            }
            while (current >= 'a');
        }
    }
}
