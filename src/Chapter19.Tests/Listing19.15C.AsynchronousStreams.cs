namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_15C
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

        public static void MainEntryPoint(string[] args)
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





