namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_06
{
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
}
