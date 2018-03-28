namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_11
{
    using Listing08_02;

    interface IPerson
    {
        string FirstName
        {
            get;
            set;
        }

        string LastName
        {
            get;
            set;
        }
    }

    public class Person : IPerson
    {
        // ...
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Contact : PdaItem, IPerson
    {
        public Contact(string name)
            : base(name)
        {
        }

        private Person Person
        {
            get { return _Person; }
            set { _Person = value; }
        }
        private Person _Person;

        public string FirstName
        {
            get { return _Person.FirstName; }
            set { _Person.FirstName = value; }
        }

        public string LastName
        {
            get { return _Person.LastName; }
            set { _Person.LastName = value; }
        }

        // ...
    }

}