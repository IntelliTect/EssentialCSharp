namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_31;

public class Palindrome
{
    public static void Main()
    {
        #region INCLUDE
        string reverse, palindrome;
        char[] temp;

        Console.Write("输入一句回文: ");
        palindrome = Console.ReadLine();

        // 删除空格，并转换成小写
        reverse = palindrome.Replace(" ", "");
        reverse = reverse.ToLower();

        #region HIGHLIGHT
        // 转换成字符数组
        temp = reverse.ToCharArray();
        #endregion HIGHLIGHT

        #region HIGHLIGHT
        // 反转数组
        Array.Reverse(temp);
        #endregion HIGHLIGHT

        // 将数组转换回字符串，并检查
        // 反转后的字符串是否相等
        if (reverse == new string(temp))
        {
            Console.WriteLine(
                $"\"{palindrome}\"是回文。");
        }
        else
        {
            Console.WriteLine(
                $"\"{palindrome}\"不是回文。");
        }
        #endregion INCLUDE
    }
}
