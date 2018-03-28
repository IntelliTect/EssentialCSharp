using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_22
{
    public class Program
    {
        public static void Save(object data)
        {

            if (data is string)
            {
                string text = (string)data;
                if (text.Length > 0)
                {
                    data = Encrypt(text);
                    // ...
                }
            }
            else if (data == null)
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
