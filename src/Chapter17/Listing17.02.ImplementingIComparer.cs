namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_02
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            List<Contact> list = new List<Contact>
            {

                // Lists automatically expand as elements
                // are added
                new Contact("Sneezy", "Dwarf"),
                new Contact("Happy", "Dwarf"),
                new Contact("Dopey", "Dwarf"),
                new Contact("Doc", "Dwarf"),
                new Contact("Sleepy", "Dwarf"),
                new Contact("Bashful", "Dwarf"),
                new Contact("Grumpy", "Dwarf"),
                new Contact("Duplicate", "Dwarf"),
                new Contact("Duplicate", "Scarf")
            };

            IComparer<Contact> comparer = new NameComparison();

            list.Sort(comparer);

            foreach(Contact dwarf in list)
            {
                Console.WriteLine(dwarf.LastName + ", " + dwarf.FirstName);
            }
        }
    }

    class NameComparison : IComparer<Contact>
    {
        public int Compare(Contact? x, Contact? y)
        {
            if(Object.ReferenceEquals(x, y))
                return 0;
            if(x == null)
                return 1;
            if(y == null)
                return -1;
            int result = StringCompare(x.LastName, y.LastName);
            if(result == 0)
                result = StringCompare(x.FirstName, y.FirstName);
            return result;
        }

        private static int StringCompare(string? x, string? y)
        {
            if(Object.ReferenceEquals(x, y))
                return 0;
            if(x == null)
                return 1;
            if(y == null)
                return -1;
            return x.CompareTo(y);
        }
    }

    class Contact
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Contact(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
