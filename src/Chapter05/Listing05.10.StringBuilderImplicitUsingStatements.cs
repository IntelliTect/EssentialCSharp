#region INCLUDE
// global usingָ�ָ��ȫ���ռ���������͡����롱��Ŀ
global using System.Text;
#region EXCLUDE
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_10;
#endregion EXCLUDE
public class Program
{
    public static void Main()
    {
        // new();���÷���μ���6��
        StringBuilder name = new();

        Console.Write("�������������: ");         
        name.Append(Console.ReadLine()!.Trim());

        Console.Write("����������м�������ĸ: ");
        name.Append( $" { Console.ReadLine()!.Trim('.').Trim() }." );

        Console.Write("�������������: ");
        name.Append($" { Console.ReadLine()!.Trim() }");

        Console.WriteLine($"��ã�{name}��");
    }
}
#endregion INCLUDE
