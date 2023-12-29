namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_20;

using System;

public class Program
{
    #region INCLUDE
    // 返回一个引用
    public static ref byte FindFirstRedEyePixel(byte[] image)
    {
        // 执行图像检查(也许通过机器学习)        
        for (int counter = 0; counter < image.Length; counter++)
        {
            if (image[counter] == (byte)ConsoleColor.Red)
            {
                return ref image[counter];
            }
        }
        throw new InvalidOperationException("没有像素是红色的。");
    }
    public static void Main()
    {
        byte[] image = new byte[254];
        // 加载图像
        int index = new Random().Next(0, image.Length - 1);
        image[index] =
            (byte)ConsoleColor.Red;
        Console.WriteLine(
            $"image[{index}]={(ConsoleColor)image[index]}");
        // ...

        #region HIGHLIGHT
        // 获取对第一个红色像素的引用
        ref byte redPixel = ref FindFirstRedEyePixel(image);
        // 把它更新为黑色
        redPixel = (byte)ConsoleColor.Black;
        #endregion HIGHLIGHT
        Console.WriteLine(
            $"image[{index}]={(ConsoleColor)image[redPixel]}");
    }
    #endregion INCLUDE
}
