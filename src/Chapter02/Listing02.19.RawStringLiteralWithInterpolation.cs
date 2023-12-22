namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_19;
public class Program
{
    public static void Main()
    {
        string firstName;
        string lastName;


        Console.Write /* 不换行 */ ("请输入你的名字: ");
        firstName = Console.ReadLine();

        Console.Write /* 不换行 */ ("请输入你的姓氏: ");
        lastName = Console.ReadLine();         

        #region INCLUDE
        Console.WriteLine(
            $"""你好，我叫{firstName}。{firstName} {lastName}。""");
        #endregion INCLUDE
    }
}
