namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_26
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var patent1 =
                new
                {
                    Title = "Bifocals",
                    YearOfPublication = "1784"
                };
            var patent2 =
                new
                {
                    Title = "Phonograph",
                    YearOfPublication = "1877"
                };
            var patent3 =
                new
                {
                    patent1.Title,
                    // Renamed to show property naming
                    Year = patent1.YearOfPublication
                };

            Console.WriteLine(
                $"{ patent1.Title } ({ patent1.YearOfPublication })");
            Console.WriteLine(
                $"{ patent2.Title } ({ patent2.YearOfPublication })");


            Console.WriteLine();
            Console.WriteLine(patent1);
            Console.WriteLine(patent2);

            Console.WriteLine();
            Console.WriteLine(patent3);
        }
    }
}
