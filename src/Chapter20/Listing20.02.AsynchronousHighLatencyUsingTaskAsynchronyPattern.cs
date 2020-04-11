namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_02
{
    using System;
    using System.IO;
    using System.Net;
    using System.Linq;
    using System.Threading.Tasks;

    static public class Program
    {

        public async static Task<int> FindTextInWebUriAsync(
            string findText, string url,
            IProgress<DownloadProgressChangedEventArgs>? progressCallback = null)
        {
            int textApperanceCount = 0;

            using WebClient webClient = new WebClient();
            if (progressCallback is object)
            {
                webClient.DownloadProgressChanged += (sender, eventArgs) =>
                {
                    progressCallback.Report(eventArgs);
                };
            }

            byte[] downloadData = 
                await webClient.DownloadDataTaskAsync(url);

            using MemoryStream stream = new MemoryStream(downloadData);
            using StreamReader reader = new StreamReader(stream);

            int findIndex = 0;
            int length = 0;
            do
            {
                char[] data = new char[reader.BaseStream.Length];
                length = await reader.ReadAsync(data);
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

        async public static Task Main(string[] args)
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

            Progress<DownloadProgressChangedEventArgs> progress =
                new Progress<DownloadProgressChangedEventArgs>((value) =>
                {
                    Console.Write(".");
                }
            );

            int occurances =
                await FindTextInWebUriAsync(findText, url, progress);
            Console.WriteLine(occurances);
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
