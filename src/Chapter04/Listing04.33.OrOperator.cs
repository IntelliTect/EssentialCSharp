namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_33;

public class Program
{
    public static void Main(params string[] args)
    {
        int hourOfTheDay = int.Parse(args[0]);

        #region INCLUDE
        if ((hourOfTheDay > 23) || (hourOfTheDay < 0))
            Console.WriteLine("����������Ч��ʱ�䡣");
        #endregion INCLUDE
    }
}
