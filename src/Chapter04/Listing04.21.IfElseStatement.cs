// Justification: Checking for null isn't discussed yet.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_21;

public class TicTacToe // ����TicTacToe��
{
    public static void Main() // �����������ڵ�
    {
        #region INCLUDE
        string input;

        // ��ʾ�û�ѡ���˻���˫����Ϸ
        Console.Write($"""
                1 - �˻���ս
                2 - ˫�˶�ս
                ��ѡ��
                """
        );
        input = Console.ReadLine();

        #region HIGHLIGHT
        if (input == "1")
            // �û�ѡ���˻���ս
            Console.WriteLine("�˻���ս��");
        else
            // ���������Ĭ��˫�˶�ս(��ʹ�û�����Ĳ���2)
            Console.WriteLine("˫�˶�ս��");
        #endregion HIGHLIGHT
        #endregion INCLUDE
    }
}
