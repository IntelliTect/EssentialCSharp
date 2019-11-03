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
        public static Task<int> FindTextInWebUriAsync(
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

            Task<int> downloadTask = webClient.DownloadDataTaskAsync(url)
                .ContinueWith(antecedent =>
                {

                    using MemoryStream stream = new MemoryStream(antecedent.Result);
                    using StreamReader reader = new StreamReader(stream);

                    int findIndex = 0;
                    int length = 0;
                    do
                    {
                        char[] data = new char[reader.BaseStream.Length];
                        Task childTask = reader.ReadAsync(data, 0, (int)reader.BaseStream.Length)
                            .ContinueWith(childAnticedent =>
                            {
                                for (int i = 0; i < childAnticedent.Result; i++)
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
                            });
                    }
                    while (length != 0);
                    return textApperanceCount;
                });
            return downloadTask;
        }

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

            try
            {
                Task<int> task =
                    FindTextInWebUriAsync(findText, url);

                while (!task.Wait(100))
                {
                    Console.Write(".");
                }

                Console.WriteLine(task.Result);

            }
            catch (AggregateException exception)
            {
                exception = exception.Flatten();
                if(exception.InnerExceptions.Count != 1)
                {
                    throw new InvalidOperationException("Unexpected scenario with there being more than one inner exception.");
                }
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
                catch (WebException innerExcpetion)
                {
                    // ...
                    throw new WebException("Rethrowing...", innerExcpetion);
                }
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
