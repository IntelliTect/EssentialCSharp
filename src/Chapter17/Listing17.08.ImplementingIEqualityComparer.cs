namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_08
{
    using System;
    using System.Collections.Generic;

    class ContactEquality : IEqualityComparer<Contact>
    {
        public bool Equals(Contact? x, Contact? y)
        {
            if(Object.ReferenceEquals(x, y))
                return true;
            if(x == null || y == null)
                return false;
            return x.LastName == y.LastName &&
                x.FirstName == y.FirstName;
        }

        public int GetHashCode(Contact x)
        {
            if(x is null)
                return 0;

            int h1 = x.FirstName == null ? 0 : x.FirstName.GetHashCode();
            int h2 = x.LastName == null ? 0 : x.LastName.GetHashCode();
            return h1 * 23 + h2;
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