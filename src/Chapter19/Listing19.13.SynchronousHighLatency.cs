﻿namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_13
{
    using System;
    using System.IO;
<<<<<<< HEAD
    using System.Linq;
    using System.Net;

    static  public class Program
    {

        public static int FindTextInWebUri(
            string findText, string url)
=======
    using System.Net;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("ERROR: No findText argument specified.");
                return;
            }
            string findText = args[0];
            Console.WriteLine($"Searching for {findText}...");

            string url = "http://www.IntelliTect.com";
            if (args.Length > 1)
            {
                url = args[1];
                // Ignore additional parameters
            }
            Console.Write(url);

            int textApperanceCount = 
                FindTextInWebUri(url, findText);

            Console.WriteLine(
                textApperanceCount
                );
        }

        private static int FindTextInWebUri(
            string url, string findText)
>>>>>>> Updated examles to use WebClient
        {
            int textApperanceCount = 0;

            using WebClient webClient = new WebClient();

            byte[] downloadData = webClient.DownloadData(url);

            using MemoryStream stream = new MemoryStream(downloadData);
            using StreamReader reader = new StreamReader(stream);

            int findIndex = 0;
            int length = 0;
            do
            {
                char[] data = new char[reader.BaseStream.Length];
                length = reader.Read(data);
                for (int i = 0; i < length; i++)
                {
                    if (findText[findIndex] == data[i])
                    {
                        findIndex++;
                        if (findIndex == findText.Length)
                        {
                            // Text was found
                            textApperanceCount++;
                            findIndex = 0;
                        }
                    }
                    else
                    {
                        findIndex = 0;
                    }
                }
            }
            while (length != 0);

            return textApperanceCount;
        }

<<<<<<< HEAD
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("ERROR: No findText argument specified.");
                return;
            }
            string findText = args[0];
            Console.WriteLine($"Searching for {findText}...");

            string url = "http://www.IntelliTect.com";
            if (args.Length > 1)
            {
                url = args[1];
                // Ignore additional parameters
            }
            Console.Write(url);

            int occurances =
                FindTextInWebUri(findText, url);

            Console.WriteLine(occurances);
        }

=======
>>>>>>> Updated examles to use WebClient
        static public string FormatBytes(long bytes)
        {
            string[] magnitudes =
                new string[] { "GB", "MB", "KB", "Bytes" };
            long max =
                (long)Math.Pow(1024, magnitudes.Length);

            return string.Format("{1:##.##} {0}",
                magnitudes.FirstOrDefault(
                    magnitude =>
                        bytes > (max /= 1024)) ?? "0 Bytes",
                    (decimal)bytes / (decimal)max);
        }
    }
}
