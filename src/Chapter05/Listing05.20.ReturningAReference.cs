namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_20;

using System;

public class Program
{
    #region INCLUDE
    // ����һ������
    public static ref byte FindFirstRedEyePixel(byte[] image)
    {
        // ִ��ͼ����(Ҳ��ͨ������ѧϰ)        
        for (int counter = 0; counter < image.Length; counter++)
        {
            if (image[counter] == (byte)ConsoleColor.Red)
            {
                return ref image[counter];
            }
        }
        throw new InvalidOperationException("û�������Ǻ�ɫ�ġ�");
    }
    public static void Main()
    {
        byte[] image = new byte[254];
        // ����ͼ��
        int index = new Random().Next(0, image.Length - 1);
        image[index] =
            (byte)ConsoleColor.Red;
        Console.WriteLine(
            $"image[{index}]={(ConsoleColor)image[index]}");
        // ...

        #region HIGHLIGHT
        // ��ȡ�Ե�һ����ɫ���ص�����
        ref byte redPixel = ref FindFirstRedEyePixel(image);
        // ��������Ϊ��ɫ
        redPixel = (byte)ConsoleColor.Black;
        #endregion HIGHLIGHT
        Console.WriteLine(
            $"image[{index}]={(ConsoleColor)image[redPixel]}");
    }
    #endregion INCLUDE
}
