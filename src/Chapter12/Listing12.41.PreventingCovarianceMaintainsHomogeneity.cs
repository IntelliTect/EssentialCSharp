using AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_02;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_08;
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
        #if COMPILEERROR // EXCLUDE
        // This gives an error: Cannot convert type ...
        // But suppose it did not
        IPair<PdaItem> pdaPair = (IPair<PdaItem>) contacts;
        // This is perfectly legal, but not type-safe
        pdaPair.First = new Address("123 Sesame Street");
        #endif // COMPILEERROR // EXCLUDE
        #endregion HIGHLIGHT
        #endregion INCLUDE
    }
}

public class Address : PdaItem
{
    public Address(string address) : base(address)
    {
    }
}
