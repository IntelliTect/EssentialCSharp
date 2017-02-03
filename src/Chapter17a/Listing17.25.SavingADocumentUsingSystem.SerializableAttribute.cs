namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_25
{
    using System;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;

    public class Program
    {
        public static void Main()
        {
            Stream stream;
            Document documentBefore = new Document();
            documentBefore.Title =
                "A cacophony of ramblings from my potpourri of notes";
            Document documentAfter;

            using(stream = File.Open(
                documentBefore.Title + ".bin", FileMode.Create))
            {
                BinaryFormatter formatter =
                    new BinaryFormatter();
                formatter.Serialize(stream, documentBefore);
            }

            using(stream = File.Open(
                documentBefore.Title + ".bin", FileMode.Open))
            {
                BinaryFormatter formatter =
                    new BinaryFormatter();
                documentAfter = (Document)formatter.Deserialize(
                    stream);
            }

            Console.WriteLine(documentAfter.Title);
        }
    }
    // Serializable classes use SerializableAttribute.
    [Serializable]
    class Document
    {
        public string Title = null;
        public string Data = null;

        [NonSerialized]
        public long _WindowHandle = 0;

        class Image
        {
        }
        [NonSerialized]
        private Image Picture = new Image();
    }
}
