using AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_05;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_11;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_41;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        // ...
        Contact contact1 = new("Princess Buttercup");
        Contact contact2 = new("Inigo Montoya");
        Pair<Contact> contacts = new(contact1, contact2);

        #region HIGHLIGHT
        // This gives an error: Cannot convert type ...
        // But suppose it did not
        // IPair<PdaItem> pdaPair = (IPair<PdaItem>) contacts;
        // This is perfectly legal, but not type-safe
        // pair.First = new Address("123 Sesame Street");
        #endregion HIGHLIGHT
        #endregion INCLUDE
    }
}
