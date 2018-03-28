namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_01
{
    interface IFileCompression
    {
        void Compress(string targetFileName, string[] fileList);
        void Uncompress(
            string compressedFileName, string expandDirectoryName);
    }
}
