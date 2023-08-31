namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_24;

using System;
using System.Collections.Generic;
#region INCLUDE
public class DoNotCaptureLoop
{
    public static void Main()
    {
        var items = new string[] { "Moe", "Larry", "Curly" };
        var actions = new List<Action>();
        foreach(string item in items)
        {
            #region HIGHLIGHT
            string _item = item;
            #endregion HIGHLIGHT
            actions.Add(
                () => { Console.WriteLine(_item); });
        }
        foreach(Action action in actions)
        {
            action();
        }
    }
}
#endregion INCLUDE
