namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_17;

public class Program
{
    public static void Main()
    {
        int readValue;
        char character;
        Console.Write("随意输入，按Enter键结束：");

        while (true)
        {
            readValue = Console.Read();
            if (readValue == 13) break; // 13是Enter键的编码
            character = (char)readValue;
            Console.Write(character);
        }
    }
}
