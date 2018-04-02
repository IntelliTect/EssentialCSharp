using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_25
{
    public class Program
    {
        public static void Main()
        {
            double radius = -1;
            double area = 0;

            if(radius >= 0)
                area = Math.PI * radius * radius;
            System.Console.WriteLine(
                $"The area of the circle is: { area:0.00}");
        }
    }
}
