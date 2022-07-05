namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_05
{
    #region INCLUDE
    public class Program
    {
        #region EXCLUDE
        public static void Main()
        {
            System.Console.WriteLine(MyMethod());
        }
        #endregion

        public static bool MyMethod()
        {
            string command = ObtainCommand();
            switch (command)
            {
                case "quit":
                    return false;
                // ... omitted, other cases
                default:
                    return true;
            }
        }

        #region EXCLUDE
        private static string ObtainCommand()
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
    #endregion
}
