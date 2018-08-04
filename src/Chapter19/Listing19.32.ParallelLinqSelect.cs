namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_32
{
    using AddisonWesley.Michaelis.EssentialCSharp.Shared;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        // ...
        public List<string>
          Encrypt(IEnumerable<string> data)
        {
            return data.AsParallel().Select(
                item => Encrypt(item)).ToList();
        }

        // ...

        private string Encrypt(string item)
        {
            Console.WriteLine($">>>>>Encrypting '{ item }'.");
            Cryptographer cryptographer = new Cryptographer();
            string itemEncrypted = cryptographer.Encrypt(item);
            Console.WriteLine($"<<<<<Finished encrypting '{ itemEncrypted }'.");
            return itemEncrypted;
        }

    }
}


