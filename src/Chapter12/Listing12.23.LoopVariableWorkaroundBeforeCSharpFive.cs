namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_23
{
    using System;
    using System.Collections.Generic;

    class DoNotCaptureLoop
    {
        static void Main()
        {
            var items = new string[] { "Moe", "Larry", "Curly" };
            var actions = new List<Action>();
            foreach(string item in items)
            {
                string _item = item;
                actions.Add(
                    () => { Console.WriteLine(_item); });
            }
            foreach(Action action in actions)
            {
                action();
            }
        }
    }
}