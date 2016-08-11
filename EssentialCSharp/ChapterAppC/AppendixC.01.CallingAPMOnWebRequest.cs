namespace AddisonWesley.Michaelis.EssentialCSharp.AppendixC.ListingC_01
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Net;

    public class Program
    {
        public static void ChapterMain(string[] args)
        {
            string url = "http://www.intelliTect.com";
            if(args.Length > 0)
            {
                url = args[0];
            }

            Console.Write(url);
            WebRequest webRequest = WebRequest.Create(url);

            WebResponse response =
                webRequest.GetResponseAsync().Result;

            Console.Write(".....");

            using(StreamReader reader =
                new StreamReader(response.GetResponseStream()))
            {
                int length = reader.ReadToEnd().Length;
                Console.WriteLine(FormatBytes(length));
            }
        }

        static public string FormatBytes(long bytes)
        {
            string[] magnitudes =
                new string[] { "GB", "MB", "KB", "Bytes" };
            long max = (long)Math.Pow(1024, magnitudes.Length);

            return string.Format("{1:##.##} {0}",
                magnitudes.FirstOrDefault(
                    magnitude => bytes > (max /= 1024)) ?? "0 Bytes",
                    (decimal)bytes / (decimal)max).Trim();
        }
    }
}






