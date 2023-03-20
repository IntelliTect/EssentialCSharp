namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_26;

public class Program
{
    public static void Main()
    {
        double radius = -1;
        double area = 0;

        #region INCLUDE
        if (radius >= 0)
            area = Math.PI * radius * radius;
            Console.WriteLine(
                $"The area of the circle is: {area:0.00}");
        #endregion INCLUDE
    }
}
