namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_48;

public class TicTacToe // ����TicTacToe��
{
    public static void Main() // �����������ڵ�
    {
        #region INCLUDE
        // ����������Ӳ�����ʼ����
        // ---+---+---
        //  1 | 2 | 3
        // ---+---+---
        //  4 | 5 | 6
        // ---+---+---
        //  7 | 8 | 9
        // ---+---+---
        char[] cells = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        Console.Write("���ܵ�����������ʾ: ");


        // �����ʼ���ܵ�����
        foreach (char cell in cells)
        {
            if(cell != 'O' && cell != 'X')
            {
                Console.Write($"{ cell } ");
            }
        }
        #endregion INCLUDE
    }
}
