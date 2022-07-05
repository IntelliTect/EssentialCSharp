﻿// Justification: Implementation is incomplete in the catch block.
#pragma warning disable CS0168 // Variable is declared but never used
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_20
{
    using System;
    #region INCLUDE
    using System.IO;

    public class TemporaryFileStream
    {
        public TemporaryFileStream(string fileName)
        {
            File = new FileInfo(fileName);
            // For a preferable solution use FileOptions.DeleteOnClose.
            Stream = new FileStream(
                File.FullName, FileMode.OpenOrCreate,
                FileAccess.ReadWrite);
        }

        public TemporaryFileStream()
            : this(Path.GetTempFileName())
        { }

        #region HIGHLIGHT
        // Finalizer
        ~TemporaryFileStream()
        {
            try
            {
                Close();
            }
            catch (Exception exception)
            {
                // Write event to logs or UI
                // ...
            }
        }
        #endregion HIGHLIGHT

        public FileStream? Stream { get; private set; }
        public FileInfo? File { get; private set; }

        public void Close()
        {
            Stream?.Dispose();
            try
            {
                File?.Delete();
            }
            catch (IOException exception)
            {
                Console.WriteLine(exception);
            }
            Stream = null;
            File = null;
        }
    }
    #endregion INCLUDE
}