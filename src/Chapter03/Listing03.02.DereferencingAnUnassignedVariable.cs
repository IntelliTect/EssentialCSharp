namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_02;

public class Program
{
    #region INCLUDE
    #nullable enable
    public static void Main()
    {
        // ��Ϊ��ʾ���Ǳ��������������Ŀ����ʱ�ų���
        // Ҫ�������������ע�͵�#if��#endif�����м��ɡ�
        // ������Ϻ󣬼ǵûָ���
        #if COMPILEERROR // EXCLUDE
        string? text;
        // ...
        // �������ʹ����δ��ֵ�ľֲ�����'text'
        System.Console.WriteLine(text.Length);
        #endif // COMPILEERROR // EXCLUDE
    }
    #endregion INCLUDE
}
