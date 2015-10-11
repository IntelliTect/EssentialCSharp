namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_05
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Type type;
            type = typeof(System.Nullable<>);
            Console.WriteLine(type.ContainsGenericParameters);
            Console.WriteLine(type.IsGenericType);

            type = typeof(System.Nullable<DateTime>);
            Console.WriteLine(!type.ContainsGenericParameters);
            Console.WriteLine(type.IsGenericType);
        }
    }
}