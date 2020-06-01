namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_05
{
    public class Program
    {
        public static void Main()
        {
            var patent1 =
                new { Title = "Bifocals",
                    YearOfPublication = "1784" };
            var patent2 =
                new { Title = "Phonograph",
                    YearOfPublication = "1877" };

            System.Console.WriteLine(
                $"{patent1.Title} ({patent1.YearOfPublication})");
            System.Console.WriteLine(
                $"{patent2.Title} ({patent2.YearOfPublication})");
        }
    }
}
