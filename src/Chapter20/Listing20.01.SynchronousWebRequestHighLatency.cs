namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_01
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Net;

    static  public class Program
    {

        public static int FindTextInWebUri(
            string findText, string url)
        {
            int textApperanceCount = 0;

            using WebClient webClient = new WebClient();

            byte[] downloadData = 
				webClient.DownloadData(url);

            using MemoryStream stream = new MemoryStream(downloadData);
            using StreamReader reader = new StreamReader(stream);

            int findIndex = 0;
            int length = 0;
            do
            {
                char[] data = new char[reader.BaseStream.Length];
                length = reader.Read(data);
                for (int i = 0; i < length; i++)
                {
                    if (findText[findIndex] == data[i])
                    {
                        findIndex++;
                        if (findIndex == findText.Length)
                        {
                            // Text was found
                            textApperanceCount++;
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

            return textApperanceCount;
        }

        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("ERROR: No findText argument specified.");
                return;
            }
            string findText = args[0];
            Console.WriteLine($"Searching for {findText}...");

            string url = "http://www.IntelliTect.com";
            if (args.Length > 1)
            {
                url = args[1];
                // Ignore additional parameters
            }
            Console.Write(url);

            int occurances =
                FindTextInWebUri(findText, url);

            Console.WriteLine(occurances);
        }
    }
}
