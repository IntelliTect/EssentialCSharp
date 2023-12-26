#pragma warning disable CS0219 // Variable is assigned but its value is never used

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_55;

public class GoToStatements
{
    #region INCLUDE
    // ...
    public static void Main(string[] args)
    {
        bool isOutputSet = false;
        bool isFiltered = false;
        bool isRecursive = false;

        foreach(string option in args)
        {
            switch(option)
            {
                case "/out":
                    isOutputSet = true;
                    isFiltered = false;
                    // ...
                #region HIGHLIGHT
                    goto default;
                #endregion HIGHLIGHT
                case "/f":
                    isFiltered = true;
                    isRecursive = false;
                    // ...
                #region HIGHLIGHT
                    goto default;
                #endregion HIGHLIGHT
                default:
                    if(isRecursive)
                    {
                        // 向下递归遍历层次结构
                        Console.WriteLine("正在递归遍历...");
                        // ...
                    }
                    else if(isFiltered)
                    {
                        // 为筛选器清单添加选项
                        Console.WriteLine("正在筛选...");
                        // ...
                    }
                    break;
            }
        }

        // ...
    }
    #endregion INCLUDE
}
