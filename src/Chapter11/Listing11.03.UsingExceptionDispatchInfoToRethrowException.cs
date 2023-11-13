namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_03;

#region INCLUDE
using System;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;
using System.Net;
using System.Linq;
using System.IO;
#region EXCLUDE
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
#endregion EXCLUDE
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
            #region HIGHLIGHT
            ExceptionDispatchInfo.Capture(
                exception.InnerException??exception).Throw();
            #endregion HIGHLIGHT
        }
#endregion INCLUDE
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
            if (reader is not null)
                reader.Dispose();
            string text = antecedent.Result;
            Console.WriteLine(
                FormatBytes(text.Length));
        });

        return task;
    }

    public static string FormatBytes(long bytes)
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
