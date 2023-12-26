namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_20;

public class FortyTwo
{
    public static void Main()
    {
        #region INCLUDE
        const string windSpeed = "67";
        const string announcement = $"""
            华盛顿州原来的塔科马大桥
            被风速为{windSpeed}公里/小时的大风摧毁。
            """;
        Console.WriteLine(announcement);
        #endregion INCLUDE
    }
}
