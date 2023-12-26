namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_38;

public class Program
{
    public static void Main(params string[] args)
    {
        #region INCLUDE
        string[]? segments = null;
        string? uri = null;

        #region EXCLUDE
        // ����δ��ʾ����Ϊargs��һ��������Main�����ǲ�����Ϊnull�ġ�
        segments = args;        
        #endregion EXCLUDE
        int? length = segments?.Length;
        #region EXCLUDE

        // Ҳ����ģʽƥ�䡣
        // ����Ϊ����7�²Ž���������⣬���������õĲ��������
        if (length is not null and not 0) { /*...*/ }
        #endregion EXCLUDE
        if (length is not null && length != 0)
        {
            uri = string.Join('/', segments!);
        }

        if (uri is null || length is 0)
        {
            Console.WriteLine(
                "û�и������ο��Ժϲ��ˡ�");
        }
        else
        {
            Console.WriteLine(
                $"Uri: { uri }");
        }
        #endregion INCLUDE
    }
}
