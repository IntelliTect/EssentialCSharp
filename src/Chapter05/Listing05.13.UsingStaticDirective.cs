namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_13;

#region INCLUDE
using static System.Console;

public class HeyYou
{
    public static void Main()
    {
        string? firstName;  // ���ڴ洢���ֵı���
        string? lastName;   // ���ڴ洢���ϵı���

        WriteLine("�٣��㣡");

        Write("�������������: ");
        firstName = ReadLine() ?? string.Empty;

        Write("�������������: ");
        lastName = ReadLine() ?? string.Empty;

        WriteLine(
            $"���ȫ����{firstName} {lastName}��");
    }
}
#endregion INCLUDE
