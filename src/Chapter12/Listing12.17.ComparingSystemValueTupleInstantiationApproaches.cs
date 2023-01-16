namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_17;

#pragma warning disable 0219 // Disabled warning for assigned but never 
// used variables for elucidation
using Contact = Chapter12.Contact;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        #if !PRECSHARP7
        (string, Contact) keyValuePair;
        keyValuePair =
            ("555-55-5555", new Contact("Inigo Montoya"));
        #else // Use System.ValueTupe<string,Contact> prior to C# 7.0
        ValueTuple<string, Contact> keyValuePair;
        keyValuePair =
        #region HIGHLIGHT
            ValueTuple.Create(
        #endregion HIGHLIGHT
                "555-55-5555", new Contact("Inigo Montoya"));
        keyValuePair =
        #region HIGHLIGHT
            new ValueTuple<string, Contact>(
        #endregion HIGHLIGHT
                "555-55-5555", new Contact("Inigo Montoya"));
        #endif // !PRECSHARP7
        #endregion INCLUDE
    }
}
