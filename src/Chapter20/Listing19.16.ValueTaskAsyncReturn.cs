namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_16.Tests
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public partial class Program
    {
        public static async ValueTask<byte[]> CompressAsync(byte[] buffer)
        {
            if (buffer.Length == 0)
            {
                return buffer;
            }
            using (MemoryStream memoryStream = new MemoryStream())
            using (System.IO.Compression.GZipStream gZipStream =
                new System.IO.Compression.GZipStream(
                    memoryStream, System.IO.Compression.CompressionMode.Compress))
            {

                await gZipStream.WriteAsync(buffer, 0, buffer.Length);

                buffer = memoryStream.ToArray();

            }

            return buffer;
        }

        public static string UnZip(string value)
        {
            //Transform string into byte[]
            byte[] byteArray = new byte[value.Length];
            int index = 0;
            foreach (char item in value.ToCharArray())
            {
                byteArray[index++] = (byte)item;
            }

            using (System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(byteArray))
            using (System.IO.Compression.GZipStream gZipStream = new System.IO.Compression.GZipStream(memoryStream,
                    System.IO.Compression.CompressionMode.Decompress))
            {

                byteArray = new byte[byteArray.Length];

                //Decompress
                int bytesRead = gZipStream.Read(byteArray, 0, byteArray.Length);

                //Transform byte[] unzip data to string
                StringBuilder data = new System.Text.StringBuilder(bytesRead);
                //Read the number of bytes GZipStream red and do not a for each bytes in
                //resultByteArray
                for (int i = 0; i < bytesRead; i++)
                {
                    data.Append((char)byteArray[i]);
                }
                return data.ToString();
            }
        }
    }
}
