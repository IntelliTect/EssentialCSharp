namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_36;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        // ���ڣ���Ϊout����ʹ�õı�������Ҫ��������
        // double number;  
        string input;
        Console.Write("����һ������: ");
        input = Console.ReadLine();
        if (double.TryParse(input, out double number))
        {
            Console.WriteLine(
            $"���뱻�ɹ�����������: {number}.");
        }
        else
        {
            // ע�⣺number��������Ҳ���쵽����(��Ȼδ��ֵ)
            Console.WriteLine(
                "������ı�����һ����Ч�����֡�");
        }
        Console.WriteLine(
            $"'number'Ŀǰ��ֵ��: {number}");
        #endregion INCLUDE
    }
}
