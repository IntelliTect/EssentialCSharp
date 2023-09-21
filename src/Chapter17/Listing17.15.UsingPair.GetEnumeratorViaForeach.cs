namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_15;

using System;
using Listing17_14;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        var fullName = new Pair<string>("Inigo", "Montoya");
        foreach(string name in fullName)
        {
            Console.WriteLine(name);
        }
        #endregion INCLUDE
    }
}
