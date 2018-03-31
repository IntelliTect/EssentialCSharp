namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_05
{
    using System;

    public class Program
    {
        public static void Main()
        {
            System.Collections.Generic.Stack<int> stack =
                new System.Collections.Generic.Stack<int>();
            int number;
            // ...

            // This code is conceptual, not the actual code
            while(stack.Pop() != -1) //this is actually not the right logic, but the point is the while, not stack
            {
                number = stack.Peek();
                Console.WriteLine(number);
            }
        }
    }
}
