namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_45;

public class DoWhileLoop
{
    public static void Main()
    {
        int currentPlayer = 1;
        #region INCLUDE        
        // ������ʾ������ӣ�ֱ��
        // ���������ϵ�һ����Чλ�á�
        bool valid;
        do
        {
            valid = false;

            // ����ǰ�������
            Console.Write(
                $"���{currentPlayer}: ��������:");
            string? input = Console.ReadLine();

            // ��鵱ǰ��ҵ�����
            // ...

        } while(!valid);
        #endregion INCLUDE
    }
}
