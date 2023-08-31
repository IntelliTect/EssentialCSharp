namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_23;

using System;
using System.Collections.Generic;
#region INCLUDE
public class CaptureLoop
{
    public static void Main()
    {
        var items = new string[] { "Moe", "Larry", "Curly" };
        var actions = new List<Action>();
        foreach(string item in items)
        {
            actions.Add(() => { Console.WriteLine(item); });
        }
        foreach(Action action in actions)
        {
            action();
        }
    }
}
#endregion INCLUDE
