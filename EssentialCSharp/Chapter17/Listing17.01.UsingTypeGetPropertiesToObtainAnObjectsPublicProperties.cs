namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_01
{
    using System;

    public class Program
    {
        public static void Main()
        {
            DateTime dateTime = new DateTime();

            Type type = dateTime.GetType();
            foreach(
                System.Reflection.PropertyInfo property in
                    type.GetProperties())
            {
                Console.WriteLine(property.Name);
            }
        }
    }
}