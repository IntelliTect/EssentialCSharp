namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_20;
public class Triangle
{
    public static void Main()
    {
        #region INCLUDE
        string name = "Ī����˹";
        Console.Write(
            $$"""
               ��ʼ
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
               ����
               """);
        #endregion INCLUDE
    }
}