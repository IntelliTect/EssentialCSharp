namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_08
{
    using System;

    public class Program
    {
        public static void Main()
        {
            System.Collections.Generic.Stack<int> stack =
                new System.Collections.Generic.Stack<int>();
            int number;

            using(
                System.Collections.Generic.Stack<int>.Enumerator
                    enumerator = stack.GetEnumerator())
            {
                while(enumerator.MoveNext())
                {
                    number = enumerator.Current;
                    Console.WriteLine(number);
                }
            }
        }
    }
}
