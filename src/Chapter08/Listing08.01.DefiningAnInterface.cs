namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_01
{
    interface IFileCompression
    {
        void Compress(string targetFileName, string[] fileList);
        void Uncompress(
            string compressedFileName, string expandDirectoryName);
    }
}
