// Justification: Checking for null isn't discussed yet.
#pragma warning disable CS8604 // Possible null reference argument
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_25;

public class CircleAreaCalculator
{
    public static void Main()
    {
        #region INCLUDE
        double radius;  // Declare a variable to store the radius
        double area;    // Declare a variable to store the area

        Console.Write("Enter the radius of the circle: ");

        // double.Parse converts the ReadLine() 
        // return to a double
        string temp = Console.ReadLine();
        radius = double.Parse(temp);
        if(radius >= 0)
        #region HIGHLIGHT
        {
            // Calculate the area of the circle
            area = Math.PI * radius * radius;
            Console.WriteLine(
                $"The area of the circle is: {area:0.00}");
        }
        #endregion HIGHLIGHT
        else
        {
            Console.WriteLine(
                $"{radius} is not a valid radius.");
        }
        #endregion INCLUDE
    }
}
