namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_27
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class VersionableDocument : ISerializable
    {
        enum Field
        {
            Title,
            Author,
            Data,
        }

        public VersionableDocument()
        {
        }

        public string Title;
        public string Author;
        public string Data;

        #region ISerializable Members
        public void GetObjectData(
            SerializationInfo info, StreamingContext context)
        {
            info.AddValue(Field.Title.ToString(), Title);
            info.AddValue(Field.Author.ToString(), Author);
            info.AddValue(Field.Data.ToString(), Data);
        }
        public VersionableDocument(
            SerializationInfo info, StreamingContext context)
        {
            foreach(SerializationEntry entry in info)
            {
                switch((Field)Enum.Parse(typeof(Field), entry.Name))
                {
                    case Field.Title:
                        Title = info.GetString(
                              Field.Title.ToString());
                        break;
                    case Field.Author:
                        Author = info.GetString(
                            Field.Author.ToString());
                        break;
                    case Field.Data:
                        Data = info.GetString(
                            Field.Data.ToString());
                        break;
                }
            }
        }
        #endregion
    }
}