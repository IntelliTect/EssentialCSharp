namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_46;

public class BinaryConverter
{
    public static void Main()
    {
        #region INCLUDE
        const int size = 64; // Ҳ���Դ�sizeof(ulong)ȡ��
        ulong value;
        char bit;

        Console.Write("����һ������: ");
        // ʹ��long.Parse()��֧�ָ���
        // �����ulong����unchecked��ֵ��
        // ���ReadLine����null����ôʹ��"42"��ΪĬ������        
        value = (ulong)long.Parse(Console.ReadLine() ?? "42");

        // ����ʼ����(mask)��Ϊ100000...0
        ulong mask = 1UL << size - 1;
        for(int count = 0; count < size; count++)
        {
            bit = ((mask & value) > 0) ? '1' : '0';
            Console.Write(bit);
            // ��������1λ
            mask >>= 1;
        }
        #endregion INCLUDE
    }
}
