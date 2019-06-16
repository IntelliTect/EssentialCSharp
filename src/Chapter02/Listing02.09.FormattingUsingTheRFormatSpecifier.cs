namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_09
{
    public class Program
    {
        public static void Main()
        {
            const double number = 1.618033988749895;
            double result;
            string text;

            text = $"{number}";
            result = double.Parse(text);
            System.Console.WriteLine($"{result == number}: {result} == {number}");

            text = $"{number:R}";
            result = double.Parse(text);
            System.Console.WriteLine($"{result == number}: {result} == {number}");
        }
    }
}
