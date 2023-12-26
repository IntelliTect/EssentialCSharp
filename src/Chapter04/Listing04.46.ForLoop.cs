namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_46;

public class BinaryConverter
{
    public static void Main()
    {
        #region INCLUDE
        const int size = 64; // 也可以从sizeof(ulong)取得
        ulong value;
        char bit;

        Console.Write("输入一个整数: ");
        // 使用long.Parse()来支持负数
        // 假设对ulong进行unchecked赋值，
        // 如果ReadLine返回null，那么使用"42"作为默认输入        
        value = (ulong)long.Parse(Console.ReadLine() ?? "42");

        // 将初始掩码(mask)设为100000...0
        ulong mask = 1UL << size - 1;
        for(int count = 0; count < size; count++)
        {
            bit = ((mask & value) > 0) ? '1' : '0';
            Console.Write(bit);
            // 掩码右移1位
            mask >>= 1;
        }
        #endregion INCLUDE
    }
}
