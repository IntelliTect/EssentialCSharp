namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_04
{
    using Listing06_03;

    public class Program
    {
        public static void Main()
        {
            // Derived types can be implicitly converted to
            // base types
            Contact contact = new Contact();
            PdaItem item = contact;
            // ...

            // Base types must be cast explicitly to derived types
            contact = (Contact)item;
            // ...
        }
    }
}
