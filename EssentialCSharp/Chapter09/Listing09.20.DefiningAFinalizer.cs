﻿namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_20
{
    using System.IO;

    class TemporaryFileStream
    {
        public TemporaryFileStream(string fileName)
        {
            File = new FileInfo(fileName);
            Stream = new FileStream(
                File.FullName, FileMode.OpenOrCreate,
                FileAccess.ReadWrite);
        }

        public TemporaryFileStream()
            : this(Path.GetTempFileName())
        { }

        // Finalizer
        ~TemporaryFileStream()
        {
            Close();
        }

        public FileStream Stream { get; }
        public FileInfo File { get; }

        public void Close()
        {
            Stream?.Close();
            File?.Delete();
        }
    }
}