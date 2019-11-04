namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_15B
{
    using System;
    using System.IO;
    using System.Net;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class Program
    {

        async static public Task<int> FindTextInWebUriAsync(
            string findText, IEnumerable<string> urls,
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
                await webClient.DownloadDataTaskAsync(urls.First());

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

        async public static ValueTask Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("ERROR: No findText argument specified.");
                return;
            }
            string findText = args[0];
            Console.WriteLine($"Searching for {findText}...");

            string[] urls = new string[args.Length];
            if (args.Length > 1)
            {
                for (int i = 0; i < urls.Length-1; i++)
                {
                    urls[i] = args[i+1];
                    Console.Write(urls[i]);
                }
            }
            else
            {
                // The default if no Urls are specified.
                urls[0] = "http://www.IntelliTect.com";
                Console.Write(urls[0]);
            }

            Progress<DownloadProgressChangedEventArgs> progress =
                new Progress<DownloadProgressChangedEventArgs>((value) =>
                {
                    Console.Write(".");
                }
            );

            try
            {
                int occurances =
                    await FindTextInWebUriAsync(findText, urls, progress);
                Console.WriteLine(occurances);
            }
            catch (AggregateException)
            {
                throw new InvalidOperationException(
                    $"AggregateException not expected for the {nameof(FindTextInWebUriAsync)} async method.");
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
