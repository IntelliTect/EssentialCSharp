namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_16
{
    public class Program
    {
        public static void ChapterMain()
        {
            int count = 123;
            int result;
            result = count++;
            System.Console.WriteLine(
                  $"result = {result} and count = {count}");
        }
    }
}
