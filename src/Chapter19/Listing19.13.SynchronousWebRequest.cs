namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_13
{
    using System;
    using System.IO;
    using System.Net;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class Program
    {
        public static async Task Main(string[] args)
        {
            string url = "http://www.IntelliTect.com";
            if(args.Length == 0)
            {
                    throw new ArgumentException("No findString value was specified.");
            }
            string findText = args[0];
            if(args.Length > 1)
            {
                url = args[1];
                // Ignore additional parameters
            }

            try
            {
                Console.Write(url);

                WebClient webClient = new WebClient();
                webClient.DownloadProgressChanged += (sender, eventArgs) =>
                {
                    Console.Write('.');
                };

                string fileName = Path.GetTempFileName();
                await webClient.DownloadFileTaskAsync(url, fileName);

                using (StreamReader reader =
                    new StreamReader(
                        File.OpenRead(fileName)))
                {

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
                                    Console.WriteLine($"{findText} was found in {url}");
                                    return;
                                }
                            }
                            else
                            {
                                findIndex = 0;
                            }
                        }
                    }
                    while (length != 0);
                }
            }
            catch (WebException)
            {
                // ...
                throw;
            }
            catch (IOException)
            {
                // ...
                throw;
            }
            catch(NotSupportedException)
            {
                // ...
                throw;
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
                    (decimal)bytes / (decimal)max);
        }
    }
}






