namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_20
{
    using System;
    using System.IO;

    public class TemporaryFileStream
    {
        public TemporaryFileStream(string fileName)
        {
            File = new FileInfo(fileName);
            Stream = new FileStream(
                File.FullName, FileMode.OpenOrCreate,
                FileAccess.ReadWrite);
            AppDomain.CurrentDomain.ProcessExit += CurrentDomainProcessExit;
        }

        private void CurrentDomainProcessExit(object? sender, EventArgs e)
        {
            Close();
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

        protected void Close()
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
            // TODO: Verify event is registered before removing
            // to prevent removing multiple times.
            AppDomain.CurrentDomain.ProcessExit -= CurrentDomainProcessExit;
            try
            {
                // Intentionally causing an exception.
                AppDomain.CurrentDomain.ProcessExit -= CurrentDomainProcessExit;
            }
            catch(Exception exception) { Console.WriteLine(exception); }
        }
    }
}