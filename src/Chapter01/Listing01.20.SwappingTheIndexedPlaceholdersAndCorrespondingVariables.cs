namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_20;

public class Program
{
    public static void Main()
    {
        string firstName;
        string lastName;

        Console.WriteLine("�٣��㣡");

        Console.Write("�������������: ");
        firstName = Console.ReadLine();

        Console.Write("�������������: ");
        lastName = Console.ReadLine();

        #region INCLUDE
        Console.WriteLine("���ȫ����{1}, {0}��", firstName, lastName);
        #endregion INCLUDE
    }
}
