namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_21;

#region INCLUDE
public class CommentSamples
{
    public static void Main()
    {
        string firstName;  // ���ڴ洢���ֵı���
        string lastName;   // ���ڴ洢���ϵı���

        Console.WriteLine("�٣��㣡");

        Console.Write /* ������ */ ("�������������: ");
        firstName = Console.ReadLine();

        Console.Write /* ������ */ ("�������������: ");
        lastName = Console.ReadLine();

        /* ʹ���ַ�����ֵ�ڿ���̨����ʾ�ʺ���*/
        Console.WriteLine($"���ȫ����{firstName} {lastName}��");
        // �����嵥��β
    }
}
#endregion INCLUDE
