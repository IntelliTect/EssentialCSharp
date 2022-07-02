namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_15
{
    using Listing17_14;
    using System;

    public class Program
    {
        public static void Main()
        {
            var fullname = new Pair<string>("Inigo", "Montoya");
            foreach (string name in fullname)
            {
                Console.WriteLine(name);
            }
        }
    }
}
