using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_19
{
    public class Program
    {
        #region INCLUDE
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
            else if (data is null)
            {
                // ...
            }
            #region EXCLUDE
            Console.WriteLine(data);
            #endregion EXCLUDE
        }
        #endregion INCLUDE

        public static object Encrypt(string data)
        {
            // See Chapter 19 for actual encryption implementation
            return $"ENCRYPTED <{data}> ENCRYPTED";
        }
    }
}
