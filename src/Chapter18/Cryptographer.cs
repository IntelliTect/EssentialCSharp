using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Diagnostics;

namespace AddisonWesley.Michaelis.EssentialCSharp.Shared
{
    public class Cryptographer : IDisposable
    {
        #region PROPERTIES
        public SymmetricAlgorithm CryptoAlgorithm
        {
            get { return _CryptoAlgorithm; }
        }
        readonly private SymmetricAlgorithm _CryptoAlgorithm;
        #endregion PROPERTIES

        #region CONSTRUCTORS
        public Cryptographer(SymmetricAlgorithm cryptoAlgoritym)
        {
            _CryptoAlgorithm = cryptoAlgoritym;
        }

        public Cryptographer()
            : this(new RijndaelManaged())
        {
        }
        #endregion CONSTRUCTORS

        public string Encrypt(string text)
        {
            byte[] bytes = Encrypt(CryptoAlgorithm.CreateEncryptor(), Encoding.Default.GetBytes(text));
            return Encoding.Default.GetString(bytes);
        }

        public byte[] Encrypt(byte[] data)
        {
            return Encrypt(CryptoAlgorithm.CreateEncryptor(), data);
        }

        public string Encrypt(ICryptoTransform encryptor, string text)
        {
            byte[] bytes = Encrypt(encryptor, Encoding.Default.GetBytes(text));
            return Encoding.Default.GetString(bytes);
        }
        public byte[] Encrypt(ICryptoTransform encryptor, byte[] data)
        {
            if(encryptor == null)
                throw new ArgumentNullException("encryptor");
            if(data == null)
                throw new ArgumentNullException("data");

            //Encrypt the data.
            using(MemoryStream msEncrypt = new MemoryStream())
            using(CryptoStream csEncrypt = new CryptoStream(msEncrypt,
            encryptor, CryptoStreamMode.Write))
            {
                //Write all data to the crypto stream and flush it.
                csEncrypt.Write(data, 0, data.Length);
                csEncrypt.FlushFinalBlock();

                //Get encrypted array of bytes.
                byte[] encrypted = msEncrypt.ToArray();
                return encrypted;
            }
        }

        public string Decrypt(string encryptedText)
        {
            byte[] decrypt = Decrypt(CryptoAlgorithm.CreateDecryptor(), Encoding.Default.GetBytes(encryptedText));
            return Encoding.Default.GetString(decrypt);
        }


        public string Decrypt(ICryptoTransform decryptor, string encryptedText)
        {
            byte[] decrypt = Decrypt(decryptor, Encoding.Default.GetBytes(encryptedText));
            return Encoding.Default.GetString(decrypt);
        }

        public byte[] Decrypt(ICryptoTransform decryptor, byte[] encrypted)
        {
            if(decryptor == null)
                throw new ArgumentNullException("decryptor");
            if(encrypted == null)
                throw new ArgumentNullException("encrypted");

            using(MemoryStream msDecrypt = new MemoryStream(encrypted))
            using(CryptoStream csDecrypt = new CryptoStream(msDecrypt,
            decryptor, CryptoStreamMode.Read))
            {
                byte[] fromEncrypt = new byte[encrypted.Length];

                int read = csDecrypt.Read(fromEncrypt, 0,
                fromEncrypt.Length);
                if(read < fromEncrypt.Length)
                {
                    byte[] clearBytes = new byte[read];
                    Buffer.BlockCopy(fromEncrypt, 0, clearBytes, 0, read);
                    return clearBytes;
                }
                return fromEncrypt;
            }
        }

        #region IDisposable Members

        public void Dispose()
        {
            CryptoAlgorithm.Dispose();
        }

        #endregion
    }

}
