namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_15;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        char current;
        int unicodeValue;

        // ����current�ĳ�ʼֵ
        current = 'z';

        do
        {
            // ��ȡcurrent��Unicodeֵ
            unicodeValue = current;
            Console.Write($"{current}={unicodeValue}\t");

            // �̳д���Ӣ����ĸ���ǰһ����ĸ
            current--;
        }
        while(current >= 'a');
        #endregion INCLUDE
    }
}
