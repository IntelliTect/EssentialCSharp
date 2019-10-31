namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_13
{
    using System;
    using System.IO;
    using System.Net;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class Program
    {
        public static async Task Main(string[] args)
        {
            string url = "http://www.IntelliTect.com";
            if(args.Length > 0)
            {
                url = args[0];
            }

            try
            {
                Console.Write(url);

                WebClient webClient = new WebClient();
                webClient.DownloadProgressChanged += (sender, eventArgs) =>
                {
                    Console.Write('.');
                };

                string fileName = Path.GetTempFileName();
                await webClient.DownloadFileTaskAsync(url, fileName);

                using (StreamReader reader =
                    new StreamReader(
                        File.OpenRead(fileName)))
                {
                    string text =
                        reader.ReadToEnd();
                    Console.WriteLine(
                        FormatBytes(text.Length));
                }
            }
            catch (WebException)
            {
                // ...
                throw;
            }
            catch (IOException)
            {
                // ...
                throw;
            }
            catch(NotSupportedException)
            {
                // ...
                throw;
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






