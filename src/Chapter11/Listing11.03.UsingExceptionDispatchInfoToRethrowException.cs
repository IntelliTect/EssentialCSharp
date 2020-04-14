namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_03
{
#pragma warning disable 0168 // Disabled warning for unused variables for elucidation
    using System;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Runtime.ExceptionServices;
    using System.Threading.Tasks;

    public sealed class Program
    {
        public static void Main(string[] args)
        {
            string url = "http://www.IntelliTect.com";
            if (args.Length > 0)
            {
                url = args[0];
            }

            Console.Write(url);
            Task task = WriteWebRequestSizeAsync(url);
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
                ExceptionDispatchInfo.Capture(
                    exception.InnerException??exception).Throw();
            }

        }


        private static Task WriteWebRequestSizeAsync(
            string url)
        {
            StreamReader? reader = null;
            WebRequest webRequest =
                 WebRequest.Create(url);

            Task task =
                webRequest.GetResponseAsync()
            .ContinueWith(antecedent =>
            {
                WebResponse response =
                   antecedent.Result;

                reader =
                    new StreamReader(
                        response.GetResponseStream());
                return reader.ReadToEndAsync();
            })
            .Unwrap()
            .ContinueWith(antecedent =>
            {
                if (reader != null)
                    reader.Dispose();
                string text = antecedent.Result;
                Console.WriteLine(
                    FormatBytes(text.Length));
            });

            return task;
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
