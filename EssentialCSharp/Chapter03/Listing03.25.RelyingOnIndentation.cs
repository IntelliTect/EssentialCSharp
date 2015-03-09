namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_25
{
    public class Program
    {
        public static void Main()
        {
            double radius = 1;
            double area = 0;

            if(radius >= 0)
                area = 3.14 * radius * radius;
            System.Console.WriteLine(
                $"The area of the circle is: {area}");
        }
    }
}
