﻿namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_22
{
    using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_21;
    using System;
    using System.IO;

    public class Program
    {
        public static void Search()
        {
            using(TemporaryFileStream fileStream1 =
                new TemporaryFileStream(),
                fileStream2 = new TemporaryFileStream())
            {
                // Use temporary file stream;
            }
        }
    }

}