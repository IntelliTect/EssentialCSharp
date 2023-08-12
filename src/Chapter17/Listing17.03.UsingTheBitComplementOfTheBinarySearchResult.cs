namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_03;

#region INCLUDE
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<string> list = new();
        int search;

        list.Add("public");
        list.Add("protected");
        list.Add("private");

        list.Sort();

        search = list.BinarySearch("protected internal");
        if(search < 0)
        {
            list.Insert(~search, "protected internal");
        }

        foreach(string accessModifier in list)
        {
            Console.WriteLine(accessModifier);
        }
    }
}
#endregion INCLUDE
