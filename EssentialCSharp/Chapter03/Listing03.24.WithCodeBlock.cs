namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_24
{
    public class CircleAreaCalculator
    {
        static void Main()
        {
            double radius;  // Declare a variable to store the radius.
            double area;    // Declare a variable to store the area.

            System.Console.Write("Enter the radius of the circle: ");

            // double.Parse converts the ReadLine() 
            // return to a double.
            radius = double.Parse(System.Console.ReadLine());

            if (radius >= 0)
            {
                // Calculate the area of the circle.
                area = 3.14 * radius * radius;
                System.Console.WriteLine(
                    "The area of the circle is: {0}", area);
            }
            else
            {
                System.Console.WriteLine(
                    "{0} is not a valid radius.", radius);
            }
        }
    }
}
