#define CONDITION_A

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_22
{
    using System;
    using System.Diagnostics;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Begin...");
            MethodA();
            MethodB();
            Console.WriteLine("End...");
        }

        [Conditional("CONDITION_A")]
        static void MethodA()
        {
            Console.WriteLine("MethodA() executing...");
        }

        [Conditional("CONDITION_B")]
        static void MethodB()
        {
            Console.WriteLine("MethodB() executing...");
        }
    }
}