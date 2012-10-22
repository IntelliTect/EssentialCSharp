namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_05
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            Dictionary<Guid, string> dictionary =
                new Dictionary<Guid, string>();
            Guid key = Guid.NewGuid();

            dictionary.Add(key, "hello");
        }
    }
}
