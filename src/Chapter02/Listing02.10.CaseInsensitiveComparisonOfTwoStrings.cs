namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_10;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        bool ignoreCase = true;
        string option = "/help";
        // ...
        int comparison = string.Compare(option, "/Help", ignoreCase);
        bool isHelpRequested = (comparison == 0);
        // ��ʾ: �Ƿ��������: True
        Console.WriteLine($"�Ƿ��������: {isHelpRequested}");
        #endregion INCLUDE

    }
}

