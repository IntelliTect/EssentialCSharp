namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_04;

#region INCLUDE
using System.IO;
using System.Text;
using System.Threading.Tasks;

public static class Program
{
    public static async ValueTask<byte[]> CompressAsync(byte[] buffer)
    {
        if (buffer.Length == 0)
        {
            return buffer;
        }
        using MemoryStream memoryStream = new();
        using System.IO.Compression.GZipStream gZipStream =
            new(
                memoryStream, 
                    System.IO.Compression.CompressionMode.Compress);
        await gZipStream.WriteAsync(buffer.AsMemory(0, buffer.Length));

        return memoryStream.ToArray();
    }
    #region EXCLUDE

    public static string UnZip(string value)
    {
        //Transform string into byte[]
        byte[] byteArray = new byte[value.Length];
        int index = 0;
        foreach (char item in value.ToCharArray())
        {
            byteArray[index++] = (byte)item;
        }

        using MemoryStream memoryStream = new(byteArray);
        using System.IO.Compression.GZipStream gZipStream = new(memoryStream,
                System.IO.Compression.CompressionMode.Decompress);

         byteArray = new byte[byteArray.Length];

        //Decompress
        int bytesRead = gZipStream.Read(byteArray, 0, byteArray.Length);

        //Transform byte[] unzip data to string
        StringBuilder data = new(bytesRead);
        //Read the number of bytes GZipStream red and do not a for each bytes in
        //resultByteArray
        for (int i = 0; i < bytesRead; i++)
        {
            data.Append((char)byteArray[i]);
        }
        return data.ToString();
    }
    #endregion EXCLUDE
}
#endregion INCLUDE
