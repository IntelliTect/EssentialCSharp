namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_42;

#region INCLUDE
public class BinaryConverter
{
    public static void Main()
    {
        const int size = 64;
        ulong value;
        char bit;

        Console.Write("����һ������: ");
        // ʹ��long.Parse()��֧�ָ���
        // �����ulong����unchecked��ֵ
        // ���ReadLine����null����ôʹ��"42"��ΪĬ������
        value = (ulong)long.Parse(Console.ReadLine() ?? "42");

        // ����ʼ����(mask)��Ϊ100....
        ulong mask = 1UL << size - 1;
        for(int count = 0; count < size; count++)
        {
            bit = ((mask & value) != 0) ? '1' : '0';
            Console.Write(bit);
            // ��������1λ
            mask >>= 1;
        }
        Console.WriteLine();
    }
}
#endregion INCLUDE
