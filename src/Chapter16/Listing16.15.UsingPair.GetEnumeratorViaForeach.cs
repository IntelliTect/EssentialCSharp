namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_15
{
    using System;
    using Listing16_14;

    public class Program
    {
        public static void Main()
        {
            var fullname = new Pair<string>("Inigo", "Montoya");
            foreach(string name in fullname)
            {
                Console.WriteLine(name);
            }
        }
    }
}
