namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_17
{
#pragma warning disable 0219 // Disabled warning for assigned but never 
    // used variables for elucidation
    using Contact = Chapter12.Contact;

    public class Program
    {
        public static void Main()
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
