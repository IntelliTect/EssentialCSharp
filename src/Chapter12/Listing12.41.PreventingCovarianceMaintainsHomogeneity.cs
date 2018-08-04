using AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_05;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_11;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_41
{
    public class Program
    {
        public static void Main()
        {
            Contact contact1 = new Contact("Princess Buttercup");
            Contact contact2 = new Contact("Inigo Montoya");
            Pair<Contact> contacts = new Pair<Contact>(contact1, contact2);

            // This gives an error: Cannot convert type ...

            // But suppose it did not
            // IPair<PdaItem> pdaPair = (IPair<PdaItem>) contacts;
            // This is perfectly legal, but not type-safe
            // pair.First = new Address("123 Sesame Street");
        }
    }
}
