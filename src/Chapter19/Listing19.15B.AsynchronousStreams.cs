namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_15B {
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Threading.Tasks;
    using System;

    public class Program {
        async static private IAsyncEnumerable < (string Url, string Content) > WebRequestContentsAsync (
            IEnumerable<string> urls) {
            foreach (string url in urls) {
                WebRequest webRequest =
                    WebRequest.Create (url);
                WebResponse response =
                    await webRequest.GetResponseAsync ();
                using (StreamReader reader =
                    new StreamReader (
                        response.GetResponseStream ())) {
                    yield return (Url: url, Content: await reader.ReadToEndAsync ());
                }
            }
        }

        async public static Task Main (string[] args) {
            if (args.Length == 0) {
                args = new string[] { "https://www.IntelliTect.com" };
            }

            await
            foreach ((string Url, string Content) item in WebRequestContentsAsync (args)) {
                Console.Write ($"{item.Url}......");
                Console.WriteLine (FormatBytes (item.Content.Length));
            }

        }

        static public string FormatBytes (long bytes) {
            string[] magnitudes =
                new string[] { "GB", "MB", "KB", "Bytes" };
            long max =
                (long) Math.Pow (1024, magnitudes.Length);

            return string.Format ("{1:##.##} {0}",
                magnitudes.FirstOrDefault (
                    magnitude =>
                    bytes > (max /= 1024)) ?? "0 Bytes",
                (decimal) bytes / (decimal) max).Trim ();
        }
    }
}