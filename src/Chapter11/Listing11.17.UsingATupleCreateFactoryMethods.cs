namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_17
{
#pragma warning disable 0219 // Disabled warning for assigned but never 
                             // used variables for elucidation
    using System;
    using Chapter07.Listing07_11;

    public class Program
    {
        public static void ChapterMain()
        {
#if !PRECSHARP7
            (string, Contact) keyValuePair;
            keyValuePair =
                ("555-55-5555", new Contact("Inigo Montoya"));
#elif CSHARP6
            ValueTuple<string, Contact> keyValuePair;
            keyValuePair =
                new ValueTuple<string, Contact>(
                    "555-55-5555", new Contact("Inigo Montoya"));
            keyValuePair =
                ValueTuple.Create(
                    "555-55-5555", new Contact("Inigo Montoya"));
#endif // !PRECSHARP7
        }
    }
}