namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_02
{
    using System;
    using System.IO;
    using System.Net;
    using System.Runtime.ExceptionServices;
    using System.Threading.Tasks;

    static public class Program
    {
        public const string DefaultUrl = "https://IntelliTect.com";

        public static void Main(string[] args)
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
            Console.Write("\nDownloading...");
            Task task = webClient.DownloadDataTaskAsync(url)
                .ContinueWith(antecedent =>
                {
                    byte[] downloadData = antecedent.Result;
                    Console.Write("\nSearching...");
                    return CountOccurrencesAsync(
                        downloadData, findText);
                })
                .Unwrap()
                .ContinueWith(antecedent =>
                {
                    int textOccurrenceCount = antecedent.Result;
                    Console.WriteLine(
                        @$"{Environment.NewLine}'{findText}' appears {
                            textOccurrenceCount} times at URL '{url}'.");

                });

            try
            {
                while (!task.Wait(100))
                {
                    Console.Write(".");
                }
            }
            catch (AggregateException exception)
            {
                exception = exception.Flatten();
                try
                {
                    exception.Handle(innerException =>
                    {
                        // Rethrowing rather than using
                        // if condition on the type
                        ExceptionDispatchInfo.Capture(
                            innerException)
                            .Throw();
                        return true;
                    });
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
                catch (NotSupportedException)
                {
                    // ...
                    throw;
                }
            }
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
