namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_10;

#region INCLUDE
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
        #region HIGHLIGHT
            async (string webRequestUrl) =>
            #endregion HIGHLIGHT
            {
                // Error handling omitted for 
                // elucidation
                WebRequest webRequest =
                   WebRequest.Create(url);

                WebResponse response =
                #region HIGHLIGHT
                    await webRequest.GetResponseAsync();
                #endregion HIGHLIGHT

                // Explicitly counting rather than invoking
                // webRequest.ContentLength to demonstrate
                //  multiple await operators
                using (StreamReader reader =
                    new(response.GetResponseStream()))
                {
                    string text =
                    #region HIGHLIGHT
                        (await reader.ReadToEndAsync());
                    #endregion HIGHLIGHT
                    Console.WriteLine(
                        FormatBytes(text.Length));
                }
            };

        #region HIGHLIGHT
        Task task = writeWebRequestSizeAsync(url);
        #endregion HIGHLIGHT

        while (!task.Wait(100))
        {
            Console.Write(".");
        }
    }
    #region EXCLUDE
    public static string FormatBytes(long bytes)
    {
        string[] magnitudes =
            new [] { "GB", "MB", "KB", "Bytes" };
        long max =
            (long)Math.Pow(1024, magnitudes.Length);

        return string.Format("{1:##.##} {0}",
            magnitudes.FirstOrDefault(
                magnitude =>
                    bytes > (max /= 1024)) ?? "0 Bytes",
                (decimal)bytes / (decimal)max).Trim();
    }
    #endregion EXCLUDE
}
#endregion INCLUDE





