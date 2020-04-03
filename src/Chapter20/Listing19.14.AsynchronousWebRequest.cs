namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_14
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
            string url = "http://www.IntelliTect.com";
            if(args.Length > 0)
            {
                url = args[0];
            }

            Console.Write(url);

            Task task = WriteWebRequestSizeAsync(url);

            try
            {
                while(!task.Wait(100))
                {
                    Console.Write(".");
                }
            }
            catch(AggregateException exception)
            {
                exception = exception.Flatten();
                try
                {
                    exception.Handle(innerException =>
                    {
                        // Rethrowing rather than using
                        // if condition on the type
                        ExceptionDispatchInfo.Capture(
                                              exception.InnerException)
                                              .Throw();
                        return true;
                    });
                }
                catch(WebException)
                {
                    // ...
                }
                catch(IOException)
                {
                    // ...
                }
                catch(NotSupportedException)
                {
                    // ...
                }
            }
        }


        private static Task WriteWebRequestSizeAsync(
            string url)
        {
            StreamReader reader = null;
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
                if(reader != null)
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





