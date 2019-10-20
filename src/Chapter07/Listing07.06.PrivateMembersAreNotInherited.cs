// Suboptimal code left for explanation purposes.
#pragma warning disable IDE0059 // Unnecessary assignment of a value
#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_06
{

    public class PdaItem
    {
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

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
            // contact._Name = "Inigo Montoya";  //uncomment this line and it will not compile
        }
    }
#pragma warning restore CS0169
}
