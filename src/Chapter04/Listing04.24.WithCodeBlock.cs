// Justification: Checking for null isn't discussed yet.
#pragma warning disable CS8604 // Possible null reference argument
using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_24
{
    #region INCLUDE
    public class CircleAreaCalculator
    {
        public static void Main()
        {
            double radius;  // Declare a variable to store the radius
            double area;    // Declare a variable to store the area

            System.Console.Write("Enter the radius of the circle: ");

            // double.Parse converts the ReadLine() 
            // return to a double
            radius = double.Parse(System.Console.ReadLine());
            if(radius >= 0)
            #region HIGHLIGHT
            {
                // Calculate the area of the circle
                area = Math.PI * radius * radius;
                System.Console.WriteLine(
                    $"The area of the circle is: {area:0.00}");
            }
            #endregion HIGHLIGHT
            else
            {
                System.Console.WriteLine(
                    $"{radius} is not a valid radius.");
            }
        }
    }
    #endregion INCLUDE
}