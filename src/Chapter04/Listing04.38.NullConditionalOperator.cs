namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_38;

public class Program
{
    public static void Main(params string[] args)
    {
        #region INCLUDE
        string[]? segments = null;
        string? uri = null;

        #region EXCLUDE
        // 书中未显示，因为args在一个正常的Main方法是不可能为null的。
        segments = args;        
        #endregion EXCLUDE
        int? length = segments?.Length;
        #region EXCLUDE

        // 也允许模式匹配。
        // 但因为到第7章才讲到这个主题，所以书中用的不是这个。
        if (length is not null and not 0) { /*...*/ }
        #endregion EXCLUDE
        if (length is not null && length != 0)
        {
            uri = string.Join('/', segments!);
        }

        if (uri is null || length is 0)
        {
            Console.WriteLine(
                "没有更多区段可以合并了。");
        }
        else
        {
            Console.WriteLine(
                $"Uri: { uri }");
        }
        #endregion INCLUDE
    }
}
