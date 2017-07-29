using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_23
{
    class Program
    {
        public static void Main()
        {
            ObsoleteMethod();
        }

        [Obsolete]
        public static void ObsoleteMethod()//if you look through the warnings in the error list the warning will also show up in that list
        {
        }
    }
}
