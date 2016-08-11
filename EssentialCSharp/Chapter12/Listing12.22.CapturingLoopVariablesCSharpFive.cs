namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_22
{
    using System;
    using System.Collections.Generic;

    class CaptureLoop
    {
        static void ChapterMain()
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
}