namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_15
{
    public class Triangle
    {
        public static void Main()
        {
            #region INCLUDE
            string name = "mobius";
            Console.Write(
                $$"""
                Begin
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
                 /     {{{name}}} \   \   \
                /________________\   \   \
                \                 \   \  /
                 \_________________\___\/
                End
                """);
            #endregion INCLUDE
        }
    }
}
