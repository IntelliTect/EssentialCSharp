namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_50;

public class Program
{
    public static void Main()
    {
        // ...
    }

    #region INCLUDE
    public static bool ValidateAndMove(
        int[] playerPositions, int currentPlayer, string input)
    {
        bool valid = false;

        // ��鵱ǰ��ҵ�����
        switch (input)
        {
            case "1":
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
                // ������ҵ����뱣��/����
                // ...
                valid = true;
                break;
            case "":
            case "quit":
                valid = true;
                break;
            default:
                // ���������case����ƥ�䣬����������Ч
                Console.WriteLine(
                "����:  ����1-9��ֵ�� "
                + "��Enter���˳���");
                break;
        }

        return valid;
    }
    #endregion INCLUDE
}
