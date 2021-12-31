namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter21.Listing21_08
{
    using AddisonWesley.Michaelis.EssentialCSharp.Shared;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        // ...
        public static List<string>
          Encrypt(IEnumerable<string> data)
        {

            OrderedParallelQuery<string> parallelGroups =
            data.AsParallel().OrderBy(item => item);

            // Show the total count of items still
            // matches the original count
            if (data.Count() != parallelGroups.Sum(
                    item => item.Length))
            {
                throw new Exception("data.Count() != parallelGroups.Sum(item => item.Count()");
            }
            // ...

            return data.AsParallel().Select(
                item => Program.Encrypt(item)).ToList();
        }

        // ...

        private static string Encrypt(string item)
        {
            Console.WriteLine($">>>>>Encrypting '{ item }'.");
            Cryptographer cryptographer = new Cryptographer();
            string itemEncrypted = System.Text.Encoding.UTF8.GetString(cryptographer.Encrypt(item));
            Console.WriteLine($"<<<<<Finished encrypting '{ itemEncrypted }'.");
            return itemEncrypted;
        }

    }
}


