using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_20.Tests
{
    [TestClass]
    public class TemporaryFileStreamTests
    {
        const string TempFileName = "TestFile.tmp";

        [TestInitialize]
        public void TestInitialize()
        {
            DeleteTempFile();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            DeleteTempFile();
        }

        private static void DeleteTempFile()
        {
            if (File.Exists(TempFileName))
            {
                try
                {
                    File.Delete(TempFileName);
                }
                catch(IOException exception)
                {
                    if (IsFileLocked(TempFileName))
                    {
                        throw new IOException($"The file, '{TempFileName}', is in use can can't be deleted.", exception);
                    }
                }
            }
        }


        [TestMethod]
        public void Create_GivenNewDocument_FileGetsCreated()
        {
            TemporaryFileStream fileStream = new TemporaryFileStream(TempFileName);
            Assert.IsTrue(File.Exists(fileStream.File?.FullName!));
        }

        [TestMethod]
        public void Finalizer_GivenNewDocument_FinalizerDeletesIt()
        {
            Create_GivenNewDocument_FileGetsCreated();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Assert.IsFalse(File.Exists(TempFileName));
        }

        static bool IsFileLocked(string fileName)
        {
            return IsFileLocked(new FileInfo(fileName));
        }
        static bool IsFileLocked(FileInfo file)
        {
            try
            {
                if (!file.Exists) return false;
                using FileStream stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None);
                stream.Close();

                //file is not locked
                return false;
            }
            catch (IOException exception)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    const int ERROR_SHARING_VIOLATION = 32;
                    const int ERROR_LOCK_VIOLATION = 33;


                    int errorCode = Marshal.GetHRForException(exception) & ((1 << 16) - 1);
                    return errorCode == ERROR_SHARING_VIOLATION || errorCode == ERROR_LOCK_VIOLATION;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}