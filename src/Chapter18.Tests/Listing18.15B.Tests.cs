using AddisonWesley.Michaelis.EssentialCSharp.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7
{
    [TestClass]
    public partial class CustomAsyncReturn
    {
        public static async Task<string> Compress(string data)
        {
            byte[] buffer = Encoding.Default.GetBytes(data);
            buffer =  await Compress(buffer);
            return Encoding.Default.GetString(buffer);
        }

        private static async ValueTask<byte[]> Compress(byte[] buffer)
        {
            if (buffer.Length == 0)
            {
                return buffer;
            }
            using (MemoryStream memoryStream = new MemoryStream())
            using (System.IO.Compression.GZipStream gZipStream =
                new System.IO.Compression.GZipStream(
                    memoryStream, System.IO.Compression.CompressionMode.Compress))
            {

                await gZipStream.WriteAsync(buffer, 0, buffer.Length);
                gZipStream.Close();

                buffer = memoryStream.ToArray();

                //StructuralComparisons.StructuralEqualityComparer.Equals(a1, a2);

                memoryStream.Close();
            }

            return buffer;
        }

        public static string UnZip(string value)
        {
            //Transform string into byte[]
            byte[] byteArray = new byte[value.Length];
            int indexBA = 0;
            foreach (char item in value.ToCharArray())
            {
                byteArray[indexBA++] = (byte)item;
            }

            //Prepare for decompress
            System.IO.MemoryStream ms = new System.IO.MemoryStream(byteArray);
            System.IO.Compression.GZipStream sr = new System.IO.Compression.GZipStream(ms,
                System.IO.Compression.CompressionMode.Decompress);

            //Reset variable to collect uncompressed result
            byteArray = new byte[byteArray.Length];

            //Decompress
            int rByte = sr.Read(byteArray, 0, byteArray.Length);

            //Transform byte[] unzip data to string
            System.Text.StringBuilder sB = new System.Text.StringBuilder(rByte);
            //Read the number of bytes GZipStream red and do not a for each bytes in
            //resultByteArray;
            for (int i = 0; i < rByte; i++)
            {
                sB.Append((char)byteArray[i]);
            }
            sr.Close();
            ms.Close();
            sr.Dispose();
            ms.Dispose();
            return sB.ToString();
        }
        
        public async ValueTask<long> GetDirectorySizeAsync(string path, string searchPattern)
        {
            if (!Directory.EnumerateFileSystemEntries(path, searchPattern).Any())
                return 0;
            else 
                return await Task.Run<long>(()=> Directory.GetFiles(path, searchPattern, 
                    SearchOption.AllDirectories).Sum(t => (new FileInfo(t).Length)));
        }

        public async ValueTask<IEnumerable<string>> EncryptFiles<T>(
            string path, string searchPattern, SearchOption searchOption = SearchOption.AllDirectories)
        {
            if (!Directory.EnumerateFileSystemEntries(path, searchPattern).Any())
                return Enumerable.Empty<string>();
            else
            {
                
                return await Task.WhenAll(Directory.EnumerateFiles(path, searchPattern,
                    SearchOption.AllDirectories).Select(
                    (string file)=> 
                        Task<string>.Run(() => {
                            File.Encrypt(file);
                            return file; })
                        ));

            }
        }


        [TestMethod]
        public void EncryptEmpty()
        {
            string data = "";
            string encrypted = Cryptographer.Encrypt(data).Result;
            string decrypted = Cryptographer.Decrypt(encrypted).Result;
            Assert.AreNotEqual<int>(0, encrypted.Length);
            Assert.AreEqual<string>(data, decrypted);
        }

        private static Cryptographer Cryptographer { get; set; }  = new Cryptographer();

        //private static async void Encrypt(string fileName)
        //{   
        //    if (Path.GetExtension(fileName) == ".encrypt") return;
        //    File.Delete($"{fileName}.encrypt");
        //    byte[] encryptedText = await Cryptographer.Encrypt(File.ReadAllBytes(fileName));
        //    File.WriteAllBytes($"{fileName}.encrypt", encryptedText);
        //    Console.WriteLine($"<<<<<Finished encrypting '{ fileName}'.");
        //}
    }

}
