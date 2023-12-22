namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_16;
public class Program
{
    public static void Main()
    {

        string firstName;  // 用于存储名字的变量
        string lastName;   // 用于存储姓氏的变量

        Console.WriteLine("嘿，你！");

        Console.Write /* 不换行 */ ("请输入你的名字: ");
        firstName = Console.ReadLine();

        Console.Write /* 不换行 */ ("请输入你的姓氏: ");
        lastName = Console.ReadLine();

        #region INCLUDE
        /* 使用字符串插值在控制台上显示问候语*/
        Console.WriteLine($"你的全名是: {
            firstName} {lastName}。");

        #endregion INCLUDE
    }
}