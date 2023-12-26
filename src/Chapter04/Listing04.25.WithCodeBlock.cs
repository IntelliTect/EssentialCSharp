// Justification: Checking for null isn't discussed yet.
#pragma warning disable CS8604 // Possible null reference argument
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_25;

public class CircleAreaCalculator
{
    public static void Main()
    {
        #region INCLUDE
        double radius;  // ����һ���������洢�뾶
        double area;    // ����һ���������洢���

        Console.Write("����Բ�İ뾶: ");

        // double.Parse��ReadLine()���صĽ��
        // ת����һ��double
        string temp = Console.ReadLine();
        radius = double.Parse(temp);
        if(radius >= 0)
        #region HIGHLIGHT
        {
            // ����Բ�����
            area = Math.PI * radius * radius;
            Console.WriteLine(
                $"���Բ�������: {area:0.00}");
        }
        #endregion HIGHLIGHT
        else
        {
            Console.WriteLine(
                $"{radius}������Ч�뾶ֵ��");
        }
        #endregion INCLUDE
    }
}
