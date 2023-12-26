namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_51;

public class TicTacToe // ����TicTacToe��
{
    public static void Main() // �����������ڵ�
    {
        #region INCLUDE
        int winner = 0;
        // �洢ÿ����ҵ�����λ��
        int[] playerPositions = { 0, 0 };

        // Ӳ���������λ��
        //  X | 2 | O 
        // ---+---+---
        //  O | O | 6 
        // ---+---+---
        //  X | X | X 
        playerPositions[0] = 449;
        playerPositions[1] = 28;

        // �ж��Ƿ������һ��Ӯ��
        int[] winningMasks = {
            7, 56, 448, 73, 146, 292, 84, 273 };

        // ����ÿ����ʤ����(winning mask)��
        // �ж��Ƿ���һλӮ��
        #region HIGHLIGHT
        foreach (int mask in winningMasks)
        {
            #endregion HIGHLIGHT
            if ((mask & playerPositions[0]) == mask)
            {
                winner = 1;
                #region HIGHLIGHT
                break;
                #endregion HIGHLIGHT
            }
            else if((mask & playerPositions[1]) == mask)
            {
                winner = 2;
                #region HIGHLIGHT
                break;
                #endregion HIGHLIGHT
            }
            #region HIGHLIGHT
        }
        #endregion HIGHLIGHT

        Console.WriteLine($"���{ winner }��Ӯ�ҡ�");
        #endregion INCLUDE
    }
}
