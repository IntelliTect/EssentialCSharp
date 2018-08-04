namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_08
{
    using System;
    using Listing10_07;

    public class Program
    {
        public static void Main()
        {
            Coordinate coordinate1, coordinate2;
            coordinate1 = new Coordinate(
                new Longitude(48, 52), new Latitude(-2, -20));
            Arc arc = new Arc(new Longitude(3), new Latitude(1));

            coordinate2 = coordinate1 + arc;
            Console.WriteLine(coordinate2);

            coordinate2 = coordinate2 - arc;
            Console.WriteLine(coordinate2);

            coordinate2 += arc;
            Console.WriteLine(coordinate2);
        }
    }
}