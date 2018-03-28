namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_13
{
    using System;
    using System.IO;
    using System.Net;
    using System.Linq;
    using System.Net.Http;

    public class Program
    {
        public static async void Main(string[] args)
        {
            string url = "http://www.Intellitect.com";
            if(args.Length > 0)
            {
                url = args[0];
            }

            try
            {
                Console.Write(url);

                WebRequest webRequest =
                    WebRequest.Create(url);

                WebResponse response =
                    await webRequest.GetResponseAsync();

                Console.Write(".....");

                using (StreamReader reader =
                    new StreamReader(
                        response.GetResponseStream()))
                {
                    string text =
                        reader.ReadToEnd();
                    Console.WriteLine(
                        FormatBytes(text.Length));
                }
            }
            catch(WebException)
            {
                // ...
            }
            catch(IOException)
            {
                // ...
            }
            catch(NotSupportedException)
            {
                // ...
            }
        }

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






