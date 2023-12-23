namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_13;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        string[] groceryList;
        Console.Write("购物清单中有多少种商品? ");
        int size = int.Parse(Console.ReadLine());
        groceryList = new string[size];
        // ...
        #endregion INCLUDE
    }
}
