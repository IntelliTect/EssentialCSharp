// Justification: Checking for null isn't discussed yet.
#pragma warning disable CS8604 // Possible null reference argument
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_25;

public class CircleAreaCalculator
{
    public static void Main()
    {
        #region INCLUDE
        double radius;  // 声明一个变量来存储半径
        double area;    // 声明一个变量来存储面积

        Console.Write("输入圆的半径: ");

        // double.Parse将ReadLine()返回的结果
        // 转换成一个double
        string temp = Console.ReadLine();
        radius = double.Parse(temp);
        if(radius >= 0)
        #region HIGHLIGHT
        {
            // 计算圆的面积
            area = Math.PI * radius * radius;
            Console.WriteLine(
                $"这个圆的面积是: {area:0.00}");
        }
        #endregion HIGHLIGHT
        else
        {
            Console.WriteLine(
                $"{radius}不是有效半径值。");
        }
        #endregion INCLUDE
    }
}
