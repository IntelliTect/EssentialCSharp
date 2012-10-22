namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_12
{
    public class Program
    {
        public static void Main()
        {
            // ...
            string first = "first";
            string second = "second";
            Swap(ref first, ref second);

            System.Console.WriteLine(
                @"first = ""{0}"", second = ""{1}""",
                first, second);
            // ...
        }

        static void Swap(ref string x, ref string y)
        {
            string temp = x;
            x = y;
            y = temp;
        }
    }
}
