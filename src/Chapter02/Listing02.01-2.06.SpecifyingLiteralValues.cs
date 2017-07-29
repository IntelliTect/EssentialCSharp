namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_01
{
    public class Program
    {
        public static void Main()
        {
            //begin listing 2.1
            System.Console.WriteLine(42);
            System.Console.WriteLine(1.618034);
            //end listing 2.1

            //begin listing 2.2
            System.Console.WriteLine(1.618033988749895);
            //end listing 2.2

            //begin listing 2.3
            System.Console.WriteLine(1.618033988749895M);
            //end listing 2.3

            //begin listing 2.4
            System.Console.WriteLine(6.023E23F);
            //end listing 2.4

            //begin listing 2.5
            //Display the value 42 using a hexadecimal literal.
            System.Console.WriteLine(0x002A);
            //end listing 2.5

            //begin listing 2.6
            //Displays "0x2A"
            System.Console.WriteLine($"0x{42:X}");
            //end listing 2.6
        }
    }
}
