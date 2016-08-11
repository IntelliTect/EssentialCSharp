namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_17
{
    using System;
    using Chapter07.Listing07_11;

    public class Program
    {
        public static void ChapterMain()
        {
            Tuple<string, Contact> keyValuePair;
            keyValuePair =
                Tuple.Create(
                    "555-55-5555", new Contact("Inigo Montoya"));
            keyValuePair =
                new Tuple<string, Contact>(
                    "555-55-5555", new Contact("Inigo Montoya"));
        }
    }
}