namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_14
{
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
            #endregion

            System.Console.WriteLine(
                $@"first = ""{first}"", second = ""{second}""");
            // ...
        }

        #region HIGHLIGHT
        static void Swap(ref string x, ref string y)
        #endregion
        {
            string temp = x;
            x = y;
            y = temp;
        }
    }
    #endregion
}
