namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_15
{
    using System;
    using Listing17_14;

    public class Program
    {
        public static void Main()
        {
            #region INCLUDE
            var fullname = new Pair<string>("Inigo", "Montoya");
            foreach(string name in fullname)
            {
                Console.WriteLine(name);
            }
            #endregion INCLUDE
        }
    }
}
