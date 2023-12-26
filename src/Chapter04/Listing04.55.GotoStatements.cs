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
                        // ���µݹ������νṹ
                        Console.WriteLine("���ڵݹ����...");
                        // ...
                    }
                    else if(isFiltered)
                    {
                        // Ϊɸѡ���嵥���ѡ��
                        Console.WriteLine("����ɸѡ...");
                        // ...
                    }
                    break;
            }
        }

        // ...
    }
    #endregion INCLUDE
}
