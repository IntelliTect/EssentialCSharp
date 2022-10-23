namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_14A
{
    public class Triangle
    {
        public static void Main()
        {
            #region INCLUDE
            string name = "mobius";
            Console.Write(
                $$"""
                begin
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
                end
                """);
            #endregion INCLUDE
        }
    }
}
