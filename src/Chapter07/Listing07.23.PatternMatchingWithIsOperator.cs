using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_23
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
            else if (data is null)
            {
                throw new ArgumentNullException(nameof(data));
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
