namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_02;

public class HeyYou
{
    #region INCLUDE
    public static void Main()
    {
        string? firstName;  // ���ڴ洢���ֵı���
        string? lastName;   // ���ڴ洢���ϵı���

        Console.WriteLine("�٣��㣡");

        Console.Write("�������������: ");
        firstName = Console.ReadLine();

        Console.Write("�������������: ");
        lastName = Console.ReadLine();

        /* ʹ���ַ�����ֵ�ڿ���̨����ʾ�ʺ���*/
        Console.WriteLine($"���ȫ����{firstName} {lastName}��");
    }

    #endregion INCLUDE
}
