namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_02;

#region INCLUDE
using System;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;

public static class Program
{
    public static HttpClient HttpClient { get; set; } = new();
    public const string DefaultUrl = "https://IntelliTect.com";

    public static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("ERROR: No findText argument specified.");
            return;
        }
        string findText = args[0];

        string url = DefaultUrl;
        if (args.Length > 1)
        {
            url = args[1];
            // Ignore additional parameters
        }
        Console.WriteLine(
            $"Searching for '{findText}' at URL '{url}'.");

        Console.Write("Downloading...");
        Task task = HttpClient.GetByteArrayAsync(url)
            .ContinueWith(antecedent =>
            {
                byte[] downloadData = antecedent.Result;
                Console.Write($"{Environment.NewLine}Searching...");
                return CountOccurrencesAsync(
                    downloadData, findText);
            })
            .Unwrap()
            .ContinueWith(antecedent =>
            {
                int textOccurrenceCount = antecedent.Result;
                Console.WriteLine(
                     @$"{Environment.NewLine}'{findText}' appears {
                        textOccurrenceCount} times at URL '{url}'.");

            });
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
            try
            {
                exception.Handle(innerException =>
                {
                    // Rethrowing rather than using
                    // if condition on the type
                    ExceptionDispatchInfo.Capture(
                        innerException)
                        .Throw();
                    return true;
                });
            }
            catch (HttpRequestException)
            {
                #region EXCLUDE
                throw;
                #endregion EXCLUDE
            }
            catch (IOException)
            {
                #region EXCLUDE
                throw;
                #endregion EXCLUDE
            }
        }
    }


    private static async Task<int> CountOccurrencesAsync(
        byte[] downloadData, string findText)
    {
        #region EXCLUDE
        int textOccurrenceCount = 0;

        using MemoryStream stream = new(downloadData);
        using StreamReader reader = new(stream);

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
                        textOccurrenceCount++;
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

        return textOccurrenceCount;
        #endregion EXCLUDE
    }
}
#endregion INCLUDE
