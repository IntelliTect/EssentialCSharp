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
        #region 显示井字棋棋盘

        #if CSHARP2PLUS
        System.Console.Clear();
        #endif

        // 显示当前棋盘
        border = 0;   //  设置第一个界线(border[0] = "|")

        // 显示顶行连线
        // ("\n---+---+---\n")
        Console.Write(borders[2]);
        foreach(char cell in cells)
        {
            // 输出一个单元格值以及紧接在它后面的界线
            Console.Write($" { cell } { borders[border] }");

            // 递增到下一个界线
            border++;

            // 如果界线为3，就重置为0
            if(border == 3)
            {
                border = 0;
            }
        }

        #endregion 显示井字棋棋盘

        // ...
        #endregion INCLUDE
    }
}
