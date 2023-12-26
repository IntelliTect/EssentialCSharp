namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_15;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        char current;
        int unicodeValue;

        // 设置current的初始值
        current = 'z';

        do
        {
            // 获取current的Unicode值
            unicodeValue = current;
            Console.Write($"{current}={unicodeValue}\t");

            // 继承处理英语字母表的前一个字母
            current--;
        }
        while(current >= 'a');
        #endregion INCLUDE
    }
}
