namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_06
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            Stack<int> s = new Stack<int>();

            Type t = s.GetType();

            foreach (Type type in t.GetGenericArguments())
            {
                System.Console.WriteLine(
                    "Type parameter: " + type.FullName);
            }
        }
    }
}
