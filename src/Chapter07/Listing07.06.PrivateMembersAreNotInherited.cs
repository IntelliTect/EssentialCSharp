namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_06
{
// In a properly implemented class we could use our Contact class
#pragma warning disable CS0169
    public class PdaItem
    {
        private string _Name;
        // ...
    }

    public class Contact : PdaItem
    {
        // ...
    }

    public class Program
    {
        public static void Main()
        {
            Contact contact = new Contact();

            // ERROR:  'PdaItem. _Name' is inaccessible
            // due to its protection level
            //contact._Name = "Inigo Montoya";  //uncomment this line and it will not compile
        }
    }
#pragma warning restore CS0169
}
