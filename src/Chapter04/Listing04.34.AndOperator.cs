namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_34;

public class Program
{
    public static void Main(params string[] args)
    {
        int hourOfTheDay = int.Parse(args[0]);

        #region INCLUDE
        if ((10 < hourOfTheDay) && (hourOfTheDay < 24))
            Console.WriteLine("��Ӵ����Ӵ������ȥ�����ˡ�");
        #endregion INCLUDE
    }
}
