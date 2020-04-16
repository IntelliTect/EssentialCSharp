namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_02
{
    using System;
    using System.IO;
    using System.Net;
    using System.Threading.Tasks;

    static public class Program
    {
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

            IProgress<DownloadProgressChangedEventArgs> progress =
                new Progress<DownloadProgressChangedEventArgs>((value) =>
                {
                    Console.Write(".");
                }
            );

            using WebClient webClient = new WebClient();

            if (progress is object)
            {
                webClient.DownloadProgressChanged += (sender, eventArgs) =>
                {
                    progress.Report(eventArgs);
                };
            }

            Task<byte[]> taskDownload =
                webClient.DownloadDataTaskAsync(url);

            Console.WriteLine("Downloading...");

            byte[] downloadData = await taskDownload;

            Task<int> taskSearch = CountOccurrencesAsync(
             downloadData, findText);

            Console.WriteLine("Searching...");

            int textOccurrenceCount = await taskSearch;

            Console.WriteLine(textOccurrenceCount);
        }

        public async static Task<int> FindTextInWebUriAsync(
            string findText, string url,
            IProgress<DownloadProgressChangedEventArgs>? progressCallback = null)
        {
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

            return await CountOccurrencesAsync(
             downloadData, findText);
        }

        private static async Task<int> CountOccurrencesAsync(
            byte[] downloadData, string findText)
        {
            int textOccurrenceCount = 0;

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
                            textOccurrenceCount++;
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

            return textOccurrenceCount;
        }
    }
}
