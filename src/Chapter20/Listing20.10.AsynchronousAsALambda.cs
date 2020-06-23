namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_10
{
    using System;
    using System.IO;
    using System.Net;
    using System.Linq;
    using System.Threading.Tasks;

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

            Func<string, Task> writeWebRequestSizeAsync =
                async (string webRequestUrl) =>
                {
                    // Error handling omitted for 
                    // elucidation
                    WebRequest webRequest =
                       WebRequest.Create(url);

                    WebResponse response =
                        await webRequest.GetResponseAsync();

                    // Explicitly counting rather than invoking
                    // webRequest.ContentLength to demonstrate
                    //  multiple await operators
                    using (StreamReader reader =
                        new StreamReader(
                            response.GetResponseStream()))
                    {
                        string text =
                            (await reader.ReadToEndAsync());
                        Console.WriteLine(
                            FormatBytes(text.Length));
                    }
                };

            Task task = writeWebRequestSizeAsync(url);

            while(!task.Wait(100))
            {
                Console.Write(".");
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
}





