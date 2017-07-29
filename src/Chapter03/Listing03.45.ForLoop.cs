namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_43
{
    public class BinaryConverter
    {
        public static void Main()
        {
            const int size = 64;
            ulong value;
            char bit;

            System.Console.Write("Enter an integer: ");
            // Use long.Parse() so as to support negative numbers.
            // Assumes unchecked assignment to ulong.
            value = (ulong)long.Parse(System.Console.ReadLine());

            // Set initial mask to 100....
            ulong mask = 1UL << size - 1;
            for(int count = 0; count < size; count++)
            {
                bit = ((mask & value) > 0) ? '1' : '0';
                System.Console.Write(bit);
                // Shift mask one location over to the right
                mask >>= 1;
            }
        }
    }
}
