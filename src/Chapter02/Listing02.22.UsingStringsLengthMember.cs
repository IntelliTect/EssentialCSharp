namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_22;
#region INCLUDE
public class PalindromeLength
{
    public static void Main()
    {
        string palindrome;
        Console.Write("输入一句回文: ");
        palindrome = Console.ReadLine();
        Console.WriteLine(
        $"回文\"{palindrome}\"共有"
        + $" {palindrome.Length}个字。");
    }
}

#endregion INCLUDE