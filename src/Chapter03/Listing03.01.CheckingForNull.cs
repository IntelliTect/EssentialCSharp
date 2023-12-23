namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_01;

public class Program
{
    #region INCLUDE
    public static void Main(string[] args)
    {
        int? number = null;
        #region EXCLUDE
        if (args.Length>0)
        {
            number = args[0].Length;
        }
        #endregion EXCLUDE
        if (number is null)
        {
            Console.WriteLine("��ҪΪ'number'�ṩһ��ֵ��������Ϊnull��");
        }
        else
        {
            Console.WriteLine($"�����������ṩ�ĵ�һ����������{number}���ַ�/�֡�");
            Console.WriteLine($"'number'��������{number * 2}��");
        }
    }
    #endregion INCLUDE
}

