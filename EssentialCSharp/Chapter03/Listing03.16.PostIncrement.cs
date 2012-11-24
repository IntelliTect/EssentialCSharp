namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_16
{
    public class Program
    {
        public static void Main()
        {
            int count = 123;
            int result;
            result = count++;
            System.Console.WriteLine(
                "result = {0} and count = {1}", result, count);
        }
    }
}
