namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_10
{
#pragma warning disable CA1309 // Culture for the context of this book can be reasonably asserted to be en

    public class Program
    {
        public static void Main()
        {
            string option = "help";

            int comparison = string.Compare(option, "/Help", true);

            System.Console.WriteLine($"{comparison}");
        }
    }

#pragma warning restore CA1309 // Culture for the context of this book can be reasonably asserted to be en
}
