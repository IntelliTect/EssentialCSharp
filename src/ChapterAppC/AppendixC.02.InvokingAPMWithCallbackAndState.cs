namespace AddisonWesley.Michaelis.EssentialCSharp.AppendixC.ListingC_02
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Threading;

    public class Program
    {
        public static void Main(string[] args)
        {
            string url = "http://www.intelliTechture.com";
            if(args.Length > 0)
            {
                url = args[0];
            }

            Console.Write(url);
            WebRequest webRequest = WebRequest.Create(url);
            WebRequestState state =
                new WebRequestState(webRequest);
            IAsyncResult asyncResult = webRequest.BeginGetResponse(
                GetResponseAsyncCompleted, state);
            while(!asyncResult.AsyncWaitHandle.WaitOne(100))
            {
                Console.Write('.');
            }
            state.ResetEvent.Wait();
        }

        private static void GetResponseAsyncCompleted(
            IAsyncResult asyncResult)
        {
            WebRequestState completedState = (WebRequestState)asyncResult.AsyncState;
            HttpWebResponse response =
                (HttpWebResponse)completedState.WebRequest
                    .EndGetResponse(asyncResult);
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            int length = reader.ReadToEnd().Length;

            Console.WriteLine(FormatBytes(length));
            completedState.ResetEvent.Set();
            completedState.Dispose();
        }

        static public string FormatBytes(long bytes)
        {
            string[] magnitudes = new string[] { "GB", "MB", "KB", "Bytes" };
            long max = (long)Math.Pow(1024, magnitudes.Length);

            return string.Format("{1:##.##} {0}",
                magnitudes.FirstOrDefault(magnitude => bytes > (max /= 1024)) ?? "0 Bytes",
                (decimal)bytes / (decimal)max).Trim();
        }
    }

    class WebRequestState : IDisposable
    {
        public WebRequestState(WebRequest webRequest)
        {
            WebRequest = webRequest;
        }
        ~WebRequestState()
        {
            Dispose();
        }

        public WebRequest WebRequest { get; private set; }
        private ManualResetEventSlim _ResetEvent = new ManualResetEventSlim();
        public ManualResetEventSlim ResetEvent { get { return _ResetEvent; } }

        public void Dispose()
        {
            ResetEvent.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}







