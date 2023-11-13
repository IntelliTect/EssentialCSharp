namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_04;

using System;

#region INCLUDE
using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;

public static class Program
{
    public static async ValueTask<byte[]> CompressAsync(byte[] buffer)
    {
        if (buffer.Length == 0)
        {
            return buffer;
        }
        using MemoryStream outputMemoryStream = new();
        using (GZipStream gZipStream = new(outputMemoryStream, CompressionMode.Compress))
        {
            await gZipStream.WriteAsync(buffer.AsMemory(0, buffer.Length));
        }

        return outputMemoryStream.ToArray();
    }
    #region EXCLUDE
    public static async ValueTask<byte[]> Decompress(byte[] buffer)
    {
        if (buffer.Length == 0)
        {
            return buffer;
        }

        using MemoryStream inputStream = new(buffer);
        using MemoryStream uncompressedStream = new();
        using (GZipStream gZipStream = new(inputStream, CompressionMode.Decompress))
        {
            await gZipStream.CopyToAsync(uncompressedStream);
        }

        return uncompressedStream.ToArray();
    }
    #endregion EXCLUDE
}
#endregion INCLUDE
