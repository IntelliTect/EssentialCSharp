namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_03
{
    using System;
    using System.IO;
    using System.Net;
    using System.Threading.Tasks;

    static public class Program
    {
        public const string DefaultUrl = "https://IntelliTect.com";

        public static async Task Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("ERROR: No findText argument specified.");
                return;
            }
            string findText = args[0];

            string url = DefaultUrl;
            if (args.Length > 1)
            {
                url = args[1];
                // Ignore additional parameters
            }
            Console.Write($"Searching for '{findText}' at URL '{url}'.");

            using WebClient webClient = new WebClient();
            Task<byte[]> taskDownload =
                webClient.DownloadDataTaskAsync(url);

            Console.Write("\nDownloading...");
            while (!taskDownload.Wait(100))
            {
                Console.Write(".");
            }

            byte[] downloadData = await taskDownload;

            Task<int> taskSearch = CountOccurrencesAsync(
             downloadData, findText);

            Console.Write("\nSearching...");

            while (!taskSearch.Wait(100))
            {
                Console.Write(".");
            }

            int textOccurrenceCount = await taskSearch;

            Console.WriteLine(
                @$"{Environment.NewLine}'{findText}' appears {
                    textOccurrenceCount} times at URL '{url}'.");
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
