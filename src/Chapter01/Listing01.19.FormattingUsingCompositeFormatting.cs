namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_19;

#region INCLUDE
public class HeyYou
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

        Console.WriteLine(
           "你的全名是{0} {1}。", firstName, lastName);
    }
}

#endregion INCLUDE
