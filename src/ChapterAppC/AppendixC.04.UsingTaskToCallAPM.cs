namespace AddisonWesley.Michaelis.EssentialCSharp.AppendixC.ListingC_04
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Threading.Tasks;

    public class Program
    {
        static private object ConsoleSyncObject = new object();

        public static void Main(string[] args)
        {
            Console.Clear();
            string[] urls = args;
            if(args.Length == 0)
            {
                urls = new string[]  
          {
              "http://www.habitat-spokane.org",
              "http://www.partnersintl.org",
              "http://www.iassist.org ",
              "http://www.fh.org",
              "http://www.worldvision.org"
          };
            }
            Task[] tasks = new Task[urls.Length];
            for(int line = 0; line < urls.Length; line++)
            {
                tasks[line] = DisplayPageSizeAsync(
                    urls[line], line);
            }

            while(!Task.WaitAll(tasks, 50))
            {
                DisplayProgress(tasks);
            }
            Console.SetCursorPosition(0, urls.Length);
        }

        private static Task
            DisplayPageSizeAsync(string url, int line)
        {
            WebRequest webRequest = WebRequest.Create(url);
            WebRequestState state =
                new WebRequestState(webRequest, line);
            Write(state, url + " ");
            return Task<WebResponse>.Factory.FromAsync(
                    webRequest.BeginGetResponse,
                    GetResponseAsyncCompleted, state);
        }

        private static WebResponse GetResponseAsyncCompleted(
            IAsyncResult asyncResult)
        {
            WebRequestState completedState =
                    (WebRequestState)asyncResult.AsyncState;
            HttpWebResponse response =
                (HttpWebResponse)completedState.WebRequest
                    .EndGetResponse(asyncResult);
            Stream stream =
                response.GetResponseStream();
            using(StreamReader reader =
                new StreamReader(stream))
            {
                int length = reader.ReadToEnd().Length;
                Write(
                    completedState, FormatBytes(length));
            }
            return response;
        }

        private static void Write(
            WebRequestState completedState, string text)
        {
            lock(ConsoleSyncObject)
            {
                Console.SetCursorPosition(
                    completedState.ConsoleColumn,
                    completedState.ConsoleLine);
                Console.Write(text);
                completedState.ConsoleColumn +=
                    text.Length;
            }
        }

        private static void DisplayProgress(
            Task[] tasks)
        {
            for(int i = 0; i < tasks.Length; i++)
            {
                if(!tasks[i].IsCompleted)
                {
                    DisplayProgress((WebRequestState)tasks[i].AsyncState);
                }
            }
        }


        private static void DisplayProgress(
            WebRequestState state)
        {
            int left = state.ConsoleColumn;
            int top = state.ConsoleLine;
            lock(ConsoleSyncObject)
            {
                if(left >= Console.BufferWidth -
                    int.MaxValue.ToString().Length)
                {
                    left = state.Url.Length;

                    Console.SetCursorPosition(left, top);
                    Console.Write("".PadRight(
                        Console.BufferWidth -
                            state.Url.Length));

                    state.ConsoleColumn = left;
                }

                Write(state, ".");
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
                    (decimal)bytes / (decimal)max).Trim();
        }
    }

    class WebRequestState
    {
        public WebRequestState(WebRequest webRequest, int line)
        {
            WebRequest = webRequest;
            ConsoleLine = line;
            ConsoleColumn = 0;
        }
        public WebRequestState(WebRequest webRequest)
        {
            WebRequest = webRequest;
        }
        public WebRequest WebRequest { get; private set; }
        public string Url
        {
            get
            {
                return WebRequest.RequestUri.ToString();
            }
        }
        public int ConsoleLine { get; set; }
        public int ConsoleColumn { get; set; }
    }

}






