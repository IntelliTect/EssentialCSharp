using System.IO.Compression;
using System.Text;

using AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Tests;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_04.Tests;

[TestClass]
public class ValueTaskAsyncReturnTest
{
    private const string inputString = "test.cmd";
    [TestMethod]
    public async Task CompressAsync_WithEmptyBuffer_ReturnsEmptyBuffer()
    {
        byte[] buffer = Array.Empty<byte>();

        byte[] compressedBuffer = await Program.CompressAsync(buffer);

        Assert.AreEqual(buffer, compressedBuffer);
    }

    [TestMethod]
    public async Task CompressAsync_WithNonEmptyBuffer_ReturnsCompressedBuffer()
    {
        byte[] buffer = Encoding.UTF8.GetBytes(inputString);

        byte[] compressedBuffer = await Program.CompressAsync(buffer);

        Assert.AreNotEqual(buffer, compressedBuffer);
    }

    [TestMethod]
    public async Task CompressAsync_WithNonEmptyBuffer_ReturnsCompressedBufferThatCanBeDecompressed()
    {
        byte[] compressedBuffer = await Program.CompressAsync(Encoding.UTF8.GetBytes(inputString));

        byte[] decompressedBuffer = await Program.Decompress(compressedBuffer);

        Assert.AreNotEqual(compressedBuffer, decompressedBuffer);

        Assert.AreEqual(inputString, Encoding.UTF8.GetString(decompressedBuffer));
    }
}
