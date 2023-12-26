namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_44;

public class FibonacciCalculator
{
    public static void Main()
    {
        #region INCLUDE
        decimal current;
        decimal previous;
        decimal temp;
        decimal input;

        Console.Write("����һ��������:");

        // decimal.Parse��ReadLine�ķ��ؽ��ת��Ϊһ��ʮ��������
        // ���ReadLine����null������"42"��ΪĬ��ֵ��
        input = decimal.Parse(Console.ReadLine() ?? "42");

        // ��current��previous��ʼ��Ϊ1������
        // 쳲���������ǰ�����̶�������
        current = previous = 1;

        // �ж������е�ǰ��쳲��������Ƿ�
        // С���û��������        
        while (current <= input)
        {
            temp = current;
            current = previous + current;
            previous = temp; // ��ʹ��һ��������current����input��
                             // Ҳ��ִ�������䡣
        }

        Console.WriteLine(
                  $"��һ��쳲���������{ current }");
        #endregion INCLUDE
    }
}
