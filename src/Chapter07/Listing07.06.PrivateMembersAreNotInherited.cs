// Justification: Invalid code commented out resulting in partial implementation
#pragma warning disable IDE0059 // Unnecessary assignment of a value

using System.Diagnostics.CodeAnalysis;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_06
{

    public class PdaItem
    {
// Justification: Disabled pending constructor
#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
        private string _Name;
#pragma warning restore CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.

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

            // ERROR:  'PdaItem._Name' is inaccessible
            // contact._Name = "Inigo Montoya";  //uncomment this line and it will not compile
        }
    }
}
