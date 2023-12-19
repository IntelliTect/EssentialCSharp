namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_20;

public class Program
{
    public static void Main()
    {
        string firstName;
        string lastName;

        Console.WriteLine("嘿，你！");

        Console.Write("请输入你的名字: ");
        firstName = Console.ReadLine();

        Console.Write("请输入你的姓氏: ");
        lastName = Console.ReadLine();

        #region INCLUDE
        Console.WriteLine("你的全名是{1}, {0}。", firstName, lastName);
        #endregion INCLUDE
    }
}
