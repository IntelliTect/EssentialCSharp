namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_23;

public class Program
{
    public static void Main(params string[] args)
    {
        int input = int.Parse(args[0]);
        #region INCLUDE
        if (input <= 0)
            Console.WriteLine("�˳�...");
        else if (input < 9)
            Console.WriteLine(
                "�������������" +
                $"����{input}");
        else if (input > 9)
            Console.WriteLine(
                "�������������" +
                $"С��{input}");
        else
            Console.WriteLine(
                "��ȷ�����������" +
                "ֻ����9�֡�");
        #endregion INCLUDE
    }
}
