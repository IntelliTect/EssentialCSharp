namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_06
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

            dictionary[key] = "hello";
            dictionary[key] = "goodbye";
        }
    }
}