namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_05
{
    using System;
    using System.Reflection;

    public class Program
    {
        public static void ChapterMain()
        {
            Type type;
            type = typeof(System.Nullable<>);
            Console.WriteLine(type.GetTypeInfo().ContainsGenericParameters);
            Console.WriteLine(type.GetTypeInfo().IsGenericType);

            type = typeof(System.Nullable<DateTime>);
            Console.WriteLine(!type.GetTypeInfo().ContainsGenericParameters);
            Console.WriteLine(type.GetTypeInfo().IsGenericType);
        }
    }
}