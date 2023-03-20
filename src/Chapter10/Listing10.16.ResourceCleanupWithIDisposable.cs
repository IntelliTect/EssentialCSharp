namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_16;

#region INCLUDE
using System;
using System.IO;

public static class Program
{
    // ...
    public static void Search()
    {
        TemporaryFileStream fileStream =
            new();

        // Use temporary file stream
        // ...

        #region HIGHLIGHT
        fileStream.Dispose();
        #endregion HIGHLIGHT

        // ...
    }
}

class TemporaryFileStream : IDisposable
{
    public TemporaryFileStream(string fileName)
    {
        File = new FileInfo(fileName);
        Stream = new FileStream(
            File.FullName, FileMode.OpenOrCreate,
            FileAccess.ReadWrite);
    }

    public TemporaryFileStream()
        : this(Path.GetTempFileName()) { }

    ~TemporaryFileStream()
    {
        #region HIGHLIGHT
        Dispose(false);
        #endregion HIGHLIGHT
    }

    public FileStream? Stream { get; private set; }
    public FileInfo? File { get; private set; }

    #region IDisposable Members
    #region HIGHLIGHT
    public void Dispose()
    {
        Dispose(true);

        //unregister from the finalization queue.
        System.GC.SuppressFinalize(this);
    }
    #endregion HIGHLIGHT
    #endregion
    #region HIGHLIGHT
    public void Dispose(bool disposing)
    {
        // Do not dispose of an owned managed object (one with a 
        // finalizer) if called by member finalize,
        // as the owned managed objects finalize method 
        // will be (or has been) called by finalization queue 
        // processing already
        if (disposing)
        {
            Stream?.Dispose();
        }
    #endregion HIGHLIGHT
        try
        #region HIGHLIGHT
        {
            File?.Delete();
        }
        #endregion HIGHLIGHT
        catch (IOException exception)
        #region HIGHLIGHT
        {
            Console.WriteLine(exception);
        }
        #endregion HIGHLIGHT
        Stream = null;
        File = null;
    }
}
#endregion INCLUDE
