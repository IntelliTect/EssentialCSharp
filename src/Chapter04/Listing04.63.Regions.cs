namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_63;

public class Program
{
    public static void Main()
    {
        // ...

        int border;
        string[] borders = {
            "|", "|", "\n---+---+---\n", "|", "|",
            "\n---+---+---\n", "|", "|", ""
        };
        System.Collections.Generic.IEnumerable<char> cells  = new char []{
            '1', '2', '3', '4', '5', '6', '7', '8', '9'
        };

        #region INCLUDE
        // ...
        #region ��ʾ����������

        #if CSHARP2PLUS
        System.Console.Clear();
        #endif

        // ��ʾ��ǰ����
        border = 0;   //  ���õ�һ������(border[0] = "|")

        // ��ʾ��������
        // ("\n---+---+---\n")
        Console.Write(borders[2]);
        foreach(char cell in cells)
        {
            // ���һ����Ԫ��ֵ�Լ�������������Ľ���
            Console.Write($" { cell } { borders[border] }");

            // ��������һ������
            border++;

            // �������Ϊ3��������Ϊ0
            if(border == 3)
            {
                border = 0;
            }
        }

        #endregion ��ʾ����������

        // ...
        #endregion INCLUDE
    }
}
