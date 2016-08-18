namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_01
{
    using System;
    using System.Reflection;

    public class Program
    {
        public static void ChapterMain()
        {
            DateTime dateTime = new DateTime();

            Type type = dateTime.GetType();
            foreach(
                System.Reflection.PropertyInfo property in
                    type.GetTypeInfo().GetProperties())
            {
                Console.WriteLine(property.Name);
            }
        }
    }
}