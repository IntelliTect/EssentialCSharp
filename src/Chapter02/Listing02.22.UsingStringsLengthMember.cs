namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_22;
#region INCLUDE
public class PalindromeLength
{
    public static void Main()
    {
        string palindrome;
        Console.Write("����һ�����: ");
        palindrome = Console.ReadLine();
        Console.WriteLine(
        $"����\"{palindrome}\"����"
        + $" {palindrome.Length}���֡�");
    }
}

#endregion INCLUDE