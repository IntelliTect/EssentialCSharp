namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_49;

public class Program
{
    public static void Main(params string[] args)
    {
        string input = args[0];
        #region INCLUDE
        // ...

        // ��鵱ǰ��ҵ�����
        if ((input == "1") ||
            (input == "2") ||
            (input == "3") ||
            (input == "4") ||
            (input == "5") ||
            (input == "6") ||
            (input == "7") ||
            (input == "8") ||
            (input == "9"))
        {
            // ������ҵ����뱣��/����
            // ...

        }
        else if((input.Length == 0) || (input == "quit"))
        {
            // ���Ի��˳�
            // ...

        }
        else
        {
            Console.WriteLine( $"""
                    ����:  ����1-9��ֵ��
                    ��Enter���˳���
                    """);
        }

        // ...
        #endregion INCLUDE
    }
}
