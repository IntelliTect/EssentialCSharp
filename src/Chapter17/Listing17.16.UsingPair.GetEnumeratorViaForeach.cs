namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_16;

using System;
using Listing17_15;

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
