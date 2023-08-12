namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_05;

using System;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        System.Collections.Generic.Stack<int> stack = new();
        int number;
        // ...

        // This code is conceptual, not the actual code
        #if ConceptualCode
        while(stack.MoveNext())
        {   
            number = stack.Current();
            Console.WriteLine(number);
        }
        #endif // ConceptualCode

        #endregion INCLUDE

        // Actual Code
        while(stack.Pop() != -1) //this is actually not the right logic, but the point is the while, not stack
        {
            number = stack.Peek();
            Console.WriteLine(number);
        }
    }
}
