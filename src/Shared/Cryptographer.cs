using System.Security.Cryptography;
using System.Threading.Tasks;

namespace AddisonWesley.Michaelis.EssentialCSharp.Shared;

public class Cryptographer : IDisposable
{
    #region PROPERTIES
    public SymmetricAlgorithm CryptoAlgorithm { get; }
    #endregion PROPERTIES

    #region CONSTRUCTORS
    public Cryptographer(SymmetricAlgorithm cryptoAlgorithm)
    {
        CryptoAlgorithm = cryptoAlgorithm;
    }

    public Cryptographer()
        : this(Aes.Create())
    {
    }
    #endregion CONSTRUCTORS

    public byte[] Encrypt(string text)
    {
        return EncryptAsync(text).Result;
    }

    public async Task<byte[]> EncryptAsync(string text)
    {
        return await EncryptAsync(text, CryptoAlgorithm.CreateEncryptor());
    }

    public async Task<byte[]> EncryptAsync(string text, Stream outputFileStream)
    {
        return await EncryptAsync(text, CryptoAlgorithm.CreateEncryptor(), outputFileStream);
    }

    public static async Task<byte[]> EncryptAsync(string plainText, byte[] key, byte[] iv)
    {
        byte[] encrypted;
        // Create a new AesManaged.    
        using (AesManaged aes = new())
        {
            // Create encryptor    
            ICryptoTransform encryptor = aes.CreateEncryptor(key, iv);
            // Create MemoryStream    
            encrypted = await EncryptAsync(plainText, encryptor);
        }
        // Return encrypted data    
        return encrypted;
    }

    private static async Task<byte[]> EncryptAsync(string plainText, ICryptoTransform encryptor)
    {
        using MemoryStream memoryStream = new();
        return await EncryptAsync(plainText, encryptor, memoryStream);
    }

    private static async Task<byte[]> EncryptAsync(string plainText, ICryptoTransform encryptor, Stream outputStream)
    {
        byte[] encrypted;
        MemoryStream memoryStream;

        // Create crypto stream using the CryptoStream class. This class is the key to encryption    
        // and encrypts and decrypts data from any given stream. In this case, we will pass a memory stream    
        // to encrypt    
        using (CryptoStream cryptoStream = new(outputStream, encryptor, CryptoStreamMode.Write))
        // Create StreamWriter and write data to a stream    
        using (StreamWriter streamWriter = new(cryptoStream))
        {
            await streamWriter.WriteAsync(plainText);
            if (outputStream is MemoryStream)
            {
                streamWriter.Close();
                memoryStream = (MemoryStream)outputStream;
            }
            else
            {
                using (memoryStream = new())
                {
                    outputStream.CopyTo(memoryStream);
                }
            }
            encrypted = memoryStream.ToArray();
        }

        return encrypted;
    }

    public string Decrypt(byte[] encryptedData)
    {
        return DecryptAsync(encryptedData).Result;
    }

    public async Task<string> DecryptAsync(byte[] encryptedData)
    {
        return await DecryptAsync(encryptedData, CryptoAlgorithm.CreateDecryptor());
    }

    public async Task DecryptAsync(byte[] encryptedData, Stream outputStream)
    {
        await DecryptAsync(encryptedData, CryptoAlgorithm.CreateDecryptor(), outputStream);
    }

    public static async Task<string> DecryptAsync(byte[] encryptedData, byte[] key, byte[] iV)
    {
        string plaintext;
        // Create AesManaged    
        using AesManaged aes = new();
        // Create a decryptor    
        ICryptoTransform decryptor = aes.CreateDecryptor(key, iV);
        // Create the streams used for decryption.    
        plaintext = await DecryptAsync(encryptedData, decryptor);
        return plaintext;
    }

    private static async Task<string> DecryptAsync(byte[] encryptedData, ICryptoTransform decryptor)
    {
        using MemoryStream encryptedStream = new(encryptedData);
        return await DecryptAsync(encryptedStream, decryptor);
    }

    private static async Task DecryptAsync(byte[] encryptedData, ICryptoTransform decryptor, Stream outputStream)
    {
        using MemoryStream encryptedStream = new(encryptedData);
        await DecryptAsync(encryptedStream, decryptor, outputStream);
    }

    private static async Task<string> DecryptAsync(Stream encryptedStream, ICryptoTransform decryptor)
    {
        // Create crypto stream
        using CryptoStream cryptoStream = new(encryptedStream, decryptor, CryptoStreamMode.Read);
        // Read crypto stream    
        using StreamReader reader = new(cryptoStream);
        return await reader.ReadToEndAsync();
    }

    private static async Task DecryptAsync(Stream encryptedStream, ICryptoTransform decryptor, Stream decryptedStream)
    {
        // Create crypto stream
        using CryptoStream cryptoStream = new(encryptedStream, decryptor, CryptoStreamMode.Read);
        await cryptoStream.CopyToAsync(decryptedStream);
    }

    #region IDisposable Members
    bool Disposed { get; set; }
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    protected virtual void Dispose(bool disposing)
    {
        if (Disposed)
            return;

        if (disposing)
        {
            CryptoAlgorithm.Dispose();
        }

        Disposed = true;
    }
    #endregion
}
