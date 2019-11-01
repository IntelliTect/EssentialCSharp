namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_15
{
    using System;
    using System.IO;
    using System.Net;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Runtime.ExceptionServices;

    public class Program
    {
        public static void Main(string[] args)
        {
            try
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

                Task<int> task =
                    FindTextInWebUriAsync(url, findText, progress);

                Console.WriteLine(task.Result);

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
                            exception.InnerException!).Throw();

                        return true;
                    });
                }
                catch (WebException)
                {
                    // ...
                }
                catch (IOException)
                {
                    // ...
                }
                catch (NotSupportedException)
                {
                    // ...
                }
            }
        }

        private static async Task<int> FindTextInWebUriAsync(
            string url, string findText,
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

            byte[] downloadData = await webClient.DownloadDataTaskAsync(url);

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
