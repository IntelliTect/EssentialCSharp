namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_26
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    class EncryptableDocument :
        ISerializable
    {
        public EncryptableDocument() { }

        enum Field
        {
            Title,
            Data
        }
        public string Title;
        public string Data;

        public static string Encrypt(string data)
        {
            string encryptedData = data;
            // Key-based encryption ...
            return encryptedData;
        }

        public static string Decrypt(string encryptedData)
        {
            string data = encryptedData;
            // Key-based decryption...
            return data;
        }

        #region ISerializable Members
        public void GetObjectData(
        SerializationInfo info, StreamingContext context)
        {
            info.AddValue(
                Field.Title.ToString(), Title);
            info.AddValue(
                Field.Data.ToString(), Encrypt(Data));
        }

        public EncryptableDocument(
            SerializationInfo info, StreamingContext context)
        {
            Title = info.GetString(
                Field.Title.ToString());
            Data = Decrypt(info.GetString(
                Field.Data.ToString()));
        }
        #endregion
    }
}
