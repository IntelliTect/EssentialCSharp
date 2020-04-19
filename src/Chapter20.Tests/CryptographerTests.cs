using AddisonWesley.Michaelis.EssentialCSharp.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Security.Cryptography;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_05.Tests
{
    [TestClass]
    public class CryptographerTests
    {

        [TestMethod]
        public void EncryptAesManaged()
        {
            string text = "You've fallen for one of the two classic blunders! The first being never get involved in a land war in Asia but only slightly lesser known: never go in against a cicelean when DEATH is on the line! HAHAHAHAHAHAHA *dies* You only think I guessed wrong! That's what's so funny! I switched glasses when your back was turned! Ha ha! You fool! You fell victim to one of the classic blunders - The most famous of which is 'never get involved in a land war in Asia' - but only slightly less well - known is this: 'Never go against a Sicilian when death is on the line!' Ha ha ha ha ha ha ha!";

            // Create Aes that generates a new key and initialization vector (IV).    
            // Same key must be used in encryption and decryption    
            using (AesManaged aes = new AesManaged())
            {
                // Encrypt string    
                byte[] encrypted = Cryptographer.EncryptAsync(text, aes.Key, aes.IV).Result;
                // Decrypt the bytes to a string.    
                string decrypted = Cryptographer.DecryptAsync(encrypted, aes.Key, aes.IV).Result;
                // Print decrypted string. It should be same as raw data    
                Assert.AreEqual<string>(text, decrypted);
            }
        }
    }
}