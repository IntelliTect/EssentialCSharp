namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_01;

#region INCLUDE
interface IFileCompression
{
    void Compress(string targetFileName, string[] fileList);
    void Uncompress(
        string compressedFileName, string expandDirectoryName);
}
#endregion INCLUDE
