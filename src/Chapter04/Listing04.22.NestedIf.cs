// Justification: Checking for null isn't discussed yet.
#pragma warning disable CS8604 // Possible null reference argument
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_22;

public class TicTacToeTrivia
{
    public static void Main()
    {
        #region INCLUDE
        int input;    // ����һ���������洢�û�����

        Console.Write(
            "�������������" +
            "���ٲ�?" +
            " (����0�˳�): ");

        // int.Parse()��ReadLine()��
        // ����ֵת��Ϊint
        input = int.Parse(Console.ReadLine());

        // ����1
        if (input <= 0)
            // ����С�ڵ���0
            Console.WriteLine("�˳�...");
        else
            // ����2
            if (input < 9)
            // ����С��9
            Console.WriteLine(
                "�����������" +
                $"����{input}");
        else
                // ����3
                if (input > 9)
            // �������9
            Console.WriteLine(
                "�����������" +
                $"С��{input}");
        // ����4
        else
            // �������9
            Console.WriteLine(
                "��ȷ�����������" +
                "ֻ����9����");
        #endregion INCLUDE
    } 
}
