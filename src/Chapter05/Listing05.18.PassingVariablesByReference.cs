namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_18;

#region INCLUDE
public class Program
{
    public static void Main()
    {
        // ...
        string first = "hello";
        string second = "goodbye";
        #region HIGHLIGHT
        Swap(ref first, ref second);
        #endregion HIGHLIGHT

        Console.WriteLine(
            $@"first = ""{ first }"", second = ""{ second }""");
        // ...
    }

    #region HIGHLIGHT
    static void Swap(ref string x, ref string y)
    #endregion HIGHLIGHT
    {
        string temp = x;
        x = y;
        y = temp;
    }
}
#endregion INCLUDE
