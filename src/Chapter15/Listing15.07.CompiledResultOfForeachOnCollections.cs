namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_07
{
    using System;

    public class Program
    {
        public static void Main()
        {
            System.Collections.Generic.Stack<int> stack =
                new System.Collections.Generic.Stack<int>();
            System.Collections.Generic.Stack<int>.Enumerator enumerator;
            IDisposable disposable;

            enumerator = stack.GetEnumerator();
            try
            {
                int number;
                while(enumerator.MoveNext())
                {
                    number = enumerator.Current;
                    Console.WriteLine(number);
                }
            }
            finally
            {
                // Explicit cast used for IEnumerator<T>
                disposable = (IDisposable)enumerator;
                disposable.Dispose();

                // IEnumerator will use the as operator unless IDisposable
                // support is known at compile time
                // disposable = (enumerator as IDisposable);
                // if (disposable != null)
                // {
                //     disposable.Dispose();
                // }
            }
        }
    }
}
