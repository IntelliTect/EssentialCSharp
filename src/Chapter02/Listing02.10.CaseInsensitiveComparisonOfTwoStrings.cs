namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_10
{
    public class Program
    {
        public static void Main()
        {
            #region INCLUDE
            string option = "help";

            int comparison = string.Compare(option, "/Help", true);
            #endregion INCLUDE

            System.Console.WriteLine($"{comparison}");
        }
    }
}
