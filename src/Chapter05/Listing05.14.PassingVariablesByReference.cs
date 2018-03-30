namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_14
{
    public class Program
    {
        public static void Main()
        {
            // ...
            string first = "hello";
            string second = "goodbye";
            Swap(ref first, ref second);

            System.Console.WriteLine(
                $@"first = ""{ first }"", second = ""{ second }""");
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
