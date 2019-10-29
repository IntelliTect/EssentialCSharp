<<<<<<< HEAD
<<<<<<< HEAD
﻿namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_15B
{
    using System;
    using System.IO;
    using System.Net;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    static public class Program
    {

        async static public IAsyncEnumerable<int> FindTextInWebUriAsync(
            string findText, IEnumerable<string> urls,
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

            if(urls is null)
            {
                throw new ArgumentNullException(nameof(urls));
            }

            foreach (string url in urls)
            {
                int textApperanceCount = 0;

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
                yield return textApperanceCount;
            }
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

            // ERROR: Not allowed in Async Method
            // Span<string> urls = args.AsSpan(1..);

            IEnumerable<string> urls;
            if (args.Length > 1)
            {
                urls = args.Skip(1);
            }
            else
            {
                // The default if no Urls are specified.
                urls = new string[] { "http://www.IntelliTect.com" };
            }

            Progress<DownloadProgressChangedEventArgs> progress =
                new Progress<DownloadProgressChangedEventArgs>((value) =>
                {
                    Console.Write(".");
                }
            );

            try
            {
                IEnumerator<string> urlsEnumerator = urls.GetEnumerator();
                await foreach (int occurances in
                    FindTextInWebUriAsync(findText, urls, progress))
                {
                    urlsEnumerator.MoveNext();

                    Console.WriteLine($"{urlsEnumerator.Current}....{occurances}");
                }
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
=======
﻿namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_15B
{
    using System;
    using System.IO;
    using System.Net;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class Program
    {
        private static async Task<int> WriteWebRequestSizeAsync(
            string url)
        {
            WebRequest webRequest =
                WebRequest.Create(url);

            WebResponse response =
                await webRequest.GetResponseAsync();
            using (StreamReader reader =
                new StreamReader(
                    response.GetResponseStream()))
            {
                string text =
                    await reader.ReadToEndAsync();
                return text.Length;
            }
        }

        class ConsoleLocation
        {
            public ConsoleLocation(Task task) { Task = task; }
            public Task Task {get;}
            public int Column { get; set; }
            public int Row { get; set; }
        }

        public static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                (Task<int> Task, int Column, int Row)[] items = args.Select(url =>
                {
                    Console.Write(url);
                    return (Task: WriteWebRequestSizeAsync(url), Column:  Console.CursorLeft, Row: Console.CursorTop );
                }).ToArray();
                Task[] tasks = items.Select(item => item.Task).ToArray();
                while (Task.WaitAll(tasks, 100))
                {
                    for(int count=0;count<items.Length;count++)
                    {
                        WriteToConsoleLocation(ref items[count], ".");
                    }
                }
                for (int count = 0; count < items.Length; count++)
                {
                    WriteToConsoleLocation(ref items[count], items[count].Task.Result.ToString());
                }
                Console.WriteLine();
            }
            else
            {
                string url = "http://www.IntelliTect.com";
                Console.Write(url);
                Task<int> task = WriteWebRequestSizeAsync(url);

                while (!task.Wait(100))
                {
                    Console.Write(".");
                }
                Console.WriteLine(FormatBytes(task.Result));
            }
        }

        private static void WriteToConsoleLocation(
            ref (Task<int> Task, int Column, int Row) item, string text)
        {
            Console.SetCursorPosition(item.Column, item.Row);
            Console.Write(text);
            item.Column = Console.CursorLeft;
            item.Row = Console.CursorTop;
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
                    (decimal)bytes / (decimal)max).Trim();
        }
    }
}





>>>>>>> Refactoring Console invocations into Main exclusively; Started working on Async Stream example.
=======
﻿namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_15B
{
    using System;
    using System.IO;
    using System.Net;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class Program
    {
        private static async Task<int> WriteWebRequestSizeAsync(
            string url)
        {
            WebRequest webRequest =
                WebRequest.Create(url);

            WebResponse response =
                await webRequest.GetResponseAsync();
            using (StreamReader reader =
                new StreamReader(
                    response.GetResponseStream()))
            {
                string text =
                    await reader.ReadToEndAsync();
                return text.Length;
            }
        }

        class ConsoleLocation
        {
            public ConsoleLocation(Task task) { Task = task; }
            public Task Task {get;}
            public int Column { get; set; }
            public int Row { get; set; }
        }

        public static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                (Task<int> Task, int Column, int Row)[] items = args.Select(url =>
                {
                    Console.Write(url);
                    return (Task: WriteWebRequestSizeAsync(url), Column:  Console.CursorLeft, Row: Console.CursorTop );
                }).ToArray();
                Task[] tasks = items.Select(item => item.Task).ToArray();
                while (Task.WaitAll(tasks, 100))
                {
                    for(int count=0;count<items.Length;count++)
                    {
                        WriteToConsoleLocation(ref items[count], ".");
                    }
                }
                for (int count = 0; count < items.Length; count++)
                {
                    WriteToConsoleLocation(ref items[count], items[count].Task.Result.ToString());
                }
                Console.WriteLine();
            }
            else
            {
                string url = "http://www.IntelliTect.com";
                Console.Write(url);
                Task<int> task = WriteWebRequestSizeAsync(url);

                while (!task.Wait(100))
                {
                    Console.Write(".");
                }
                Console.WriteLine(FormatBytes(task.Result));
            }
        }

        private static void WriteToConsoleLocation(
            ref (Task<int> Task, int Column, int Row) item, string text)
        {
            Console.SetCursorPosition(item.Column, item.Row);
            Console.Write(text);
            item.Column = Console.CursorLeft;
            item.Row = Console.CursorTop;
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
                    (decimal)bytes / (decimal)max).Trim();
        }
    }
}





>>>>>>> Refactoring Console invocations into Main exclusively; Started working on Async Stream example.
