namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_17;

public class Program
{
    public static void Main()
    {
        int readValue;
        char character;
        Console.Write("�������룬��Enter��������");

        while (true)
        {
            readValue = Console.Read();
            if (readValue == 13) break; // 13��Enter���ı���
            character = (char)readValue;
            Console.Write(character);
        }
    }
}
