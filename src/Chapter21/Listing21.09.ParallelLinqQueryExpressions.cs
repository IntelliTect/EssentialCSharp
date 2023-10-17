namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter21.Listing21_09;

using AddisonWesley.Michaelis.EssentialCSharp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    // ...
    public static List<string>
      Encrypt(IEnumerable<string> data)
    {
        #region INCLUDE
        //...
        ParallelQuery<IGrouping<char, string>> parallelGroups;
        parallelGroups =
        #region HIGHLIGHT
            from text in data.AsParallel()
            orderby text
            group text by text[0];
        #endregion HIGHLIGHT

        // Show the total count of items still
        // matches the original count
        if (data.Count() != parallelGroups.Sum(
                item => item.Count()))
        {
            throw new Exception("data.Count() != parallelGroups" +
                ".Sum(item => item.Count()");
        }
        //...
        #endregion INCLUDE

        return data.AsParallel().Select(
            item => Encrypt(item)).ToList();
    }

    // ...

    private static string Encrypt(string item)
    {
        Console.WriteLine($">>>>>Encrypting '{ item }'.");
        Cryptographer cryptographer = new();
        string itemEncrypted = System.Text.Encoding.UTF8.GetString(cryptographer.Encrypt(item));
        Console.WriteLine($"<<<<<Finished encrypting '{ itemEncrypted }'.");
        return itemEncrypted;
    }

}


