namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_06
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    public class Program
    {
        public static void Main()
        {
            Stack<int> s = new Stack<int>();

            Type t = s.GetType();

            foreach(Type type in t.GetTypeInfo().GetGenericArguments())
            {
                System.Console.WriteLine(
                    "Type parameter: " + type.FullName);
            }
        }
    }
}
