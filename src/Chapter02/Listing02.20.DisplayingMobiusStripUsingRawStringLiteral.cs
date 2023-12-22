namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_20;
public class Triangle
{
    public static void Main()
    {
        #region INCLUDE
        string name = "莫比乌斯";
        Console.Write(
            $$"""
               开始
                           ____
                          /   /\
                         /   /  \
                        /   /   /\
                       /   /   /  \
                      /   /   /\   \
                     /   /   /  \   \
                    /   /   /\   \   \
                   /   /   /  \   \   \
                  /___/___/____\   \   \
                 /   {{{name}}} \   \   \
                /________________\   \   \
                \                 \   \  /
                 \_________________\___\/
               结束
               """);
        #endregion INCLUDE
    }
}