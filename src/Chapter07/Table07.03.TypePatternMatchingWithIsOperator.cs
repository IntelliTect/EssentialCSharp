using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Table07_03
{
    public class Program
    {
        public static void Save(object data)
        {
            if (data is string text && text.Length > 0)
            {
                data = Encrypt(text);
                // ...
            }
            else
            {
                throw new ArgumentException();
            }
            // ...

            Console.WriteLine(data);
        }

        private static object Encrypt(string data)
        {
            // See Chapter 19 for actual encryption implementation
            return $"ENCRYPTED <{data}> ENCRYPTED";
        }
    }
}
