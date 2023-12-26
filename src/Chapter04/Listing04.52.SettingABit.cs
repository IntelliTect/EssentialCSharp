namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_52;

public class Program
{
    public static void Main()
    {

        int[] playerPositions = { 0, 0 };
        int currentPlayer = 1;
        string input = "";

        #region INCLUDE
        int shifter;  // Ҫ�ƶ���λ������һ��bit
        int position; // Ҫ���õ�bit

        // int.Parse() ��"input"ת��Ϊ������
        // ֮����Ҫ��"int.Parse(input) - 1"������Ϊ
        // ��������㡣
        shifter = int.Parse(input) - 1;

        // ʹ����00000000000000000000000000000001
        // ��λ��Ԫ���λ�á�
        position = 1 << shifter;

        // ȡ��ǰ��ҵĵ�Ԫ�񣬲������ǽ���
        // ��λ��OR�����㣬�������µ�λ�á�
        // ����currentPlayerҪô��1��Ҫô��2��
        // ���Ҫ��ȥ1�����ܽ�currentPlayer
        // ������������������
        playerPositions[currentPlayer - 1] |= position;
        #endregion INCLUDE
    }
}
