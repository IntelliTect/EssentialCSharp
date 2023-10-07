namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_03;

#region INCLUDE
using System;
using System.IO;
using System.Threading.Tasks;

public static class Program
{
    public static HttpClient HttpClient { get; set; } = new();
    public const string DefaultUrl = "https://IntelliTect.com";

    public static async Task Main(string[] args)
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

        Task<byte[]> taskDownload =
            HttpClient.GetByteArrayAsync(url);

        Console.Write("Downloading...");
        while (!taskDownload.Wait(100))
        {
            Console.Write(".");
        }

        byte[] downloadData = await taskDownload;

        Task<int> taskSearch = CountOccurrencesAsync(
         downloadData, findText);

        Console.Write($"{Environment.NewLine}Searching...");

        while (!taskSearch.Wait(100))
        {
            Console.Write(".");
        }

        int textOccurrenceCount = await taskSearch;

        Console.WriteLine(
            @$"{Environment.NewLine}'{findText}' appears {
                textOccurrenceCount} times at URL '{url}'.");
    }


    private static async Task<int> CountOccurrencesAsync(
        byte[] downloadData, string findText)
    {
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
    }
}
#endregion INCLUDE
