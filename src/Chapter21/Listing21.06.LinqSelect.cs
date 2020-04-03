namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter21.Listing21_06
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
            return data.Select(
                item => Encrypt(item)).ToList();
        }

        // ...

        private string Encrypt(string item)
        {
            Console.WriteLine($">>>>>Encrypting '{ item }'.");
            Cryptographer cryptographer = new Cryptographer();
            string itemEncrypted = System.Text.Encoding.UTF8.GetString(cryptographer.Encrypt(item));
            Console.WriteLine($"<<<<<Finished encrypting '{ itemEncrypted }'.");
            return itemEncrypted;
        }
    }
}


