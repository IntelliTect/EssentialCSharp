using AddisonWesley.Michaelis.EssentialCSharp.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_06
{
    [TestClass]
    public class AsyncStreamsTests
    {
        public TestContext? TestContext { get; set; }

        [TestMethod]
        public async Task EncryptFilesAsync_FilesInCurrentDirectory_EncryptFilesSuccessfully()
        {

            Parallel.ForEach(Directory.EnumerateFiles(Directory.GetCurrentDirectory(), "*.encrypt"), item =>
            {
                // Delete each file with the *.encrypt extension.
                File.Delete(item);
            });

            IEnumerable<string> files = Directory.EnumerateFiles(
                Directory.GetCurrentDirectory(), "*.*");

            // Count files to start
            int count = files.Count();

            using Cryptographer cryptographer = new Cryptographer();

            try
            {

                // string text = "You've fallen for one of the two classic blunders! The first being never get involved in a land war in Asia but only slightly lesser known: never go in against a cicelean when DEATH is on the line! HAHAHAHAHAHAHA *dies* You only think I guessed wrong! That's what's so funny! I switched glasses when your back was turned! Ha ha! You fool! You fell victim to one of the classic blunders - The most famous of which is 'never get involved in a land war in Asia' - but only slightly less well - known is this: 'Never go against a Sicilian when death is on the line!' Ha ha ha ha ha ha ha!";
                await foreach (string fileName in Program.EncryptFilesAsync(files, cryptographer))
                {
                    byte[] encryptedData = await File.ReadAllBytesAsync(fileName);
                    string decryptedData = await cryptographer.DecryptAsync(encryptedData);
                    string decryptedFileName = Path.GetFileNameWithoutExtension(fileName);
                    if (File.Exists(decryptedFileName))
                    {
                        string expected = File.ReadAllText(decryptedFileName);
                        Assert.AreEqual<string>(expected, decryptedData);
                    }
                }
            }
            catch (AggregateException exception)
            {
                TestContext!.WriteLine(exception.Flatten().ToString());
                throw;
            }

            Assert.AreEqual<int>(count,
                Directory.EnumerateFiles(Directory.GetCurrentDirectory(), "*.encrypt").Count());

        }

        [TestMethod]
        [ExpectedException(typeof(OperationCanceledException))]
        public async Task EncryptFilesAsync_GivenCancellationToken_DontEncryptAllFiles()
        {

            Parallel.ForEach(Directory.EnumerateFiles(Directory.GetCurrentDirectory(), "*.encrypt"), item =>
            {
                // Delete each file with the *.encrypt extension.
                File.Delete(item);
            });


            using CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            IEnumerable<string> files = Directory.EnumerateFiles(
                Directory.GetCurrentDirectory(), "*.*");

            // Count files to start
            int unencryptedFileCount = files.Count();

            using Cryptographer cryptographer = new Cryptographer();

            int count = 0;
            int maxIterationCount = unencryptedFileCount / 2;
            try
            {
                // string text = "You've fallen for one of the two classic blunders! The first being never get involved in a land war in Asia but only slightly lesser known: never go in against a cicelean when DEATH is on the line! HAHAHAHAHAHAHA *dies* You only think I guessed wrong! That's what's so funny! I switched glasses when your back was turned! Ha ha! You fool! You fell victim to one of the classic blunders - The most famous of which is 'never get involved in a land war in Asia' - but only slightly less well - known is this: 'Never go against a Sicilian when death is on the line!' Ha ha ha ha ha ha ha!";
                await foreach (string fileName in
                    Program.EncryptFilesAsync(files, cryptographer)
                    .WithCancellation(cancellationTokenSource.Token))
                {
                    count++;
                    if (count >= maxIterationCount)
                    {
                        cancellationTokenSource.Cancel();
                    }
                }
            }
            finally
            {
                TestContext!.WriteLine($"{count}");
                Assert.IsTrue(unencryptedFileCount >
                    Directory.EnumerateFiles(Directory.GetCurrentDirectory(), "*.encrypt").Count());
                Assert.AreEqual<int>(maxIterationCount, count);
            }
        }


    }
}
