namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_06
{
    using System;

    public class Program
    {
        public static void Main()
        {
            System.Collections.Generic.Stack<int> stack =
                new System.Collections.Generic.Stack<int>();
            int number;
            System.Collections.Generic.Stack<int>.Enumerator
              enumerator;

            // ...

            // If IEnumerable<T> is implemented explicitly, 
            // then a cast is required
            // ((IEnumerable<int>)stack).GetEnumerator();
            enumerator = stack.GetEnumerator();
            while(enumerator.MoveNext())
            {
                number = enumerator.Current;
                Console.WriteLine(number);
            }
        }
    }
}
