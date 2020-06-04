namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12
{
    using Chapter08.Listing08_02;
    using System;

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
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string? _FirstName;
        public string FirstName
        {
            get => _FirstName!;
            set => _FirstName = value ?? throw new ArgumentNullException(nameof(value));
        }
        public string? _LastName;
        public string LastName
        {
            get => _LastName!;
            set => _LastName = value ?? throw new ArgumentNullException(nameof(value));
        }
    }

    public class Contact : PdaItem, IPerson
    {
        public Contact(string name)
            : base(name)
        {
        }

        private Person Person
        {
            get { return _Person!; }
            set { _Person = value ?? throw new ArgumentNullException(nameof(value)); }
        }
        private Person? _Person;

        public string FirstName
        {
            get { return Person.FirstName; }
            set { Person.FirstName = value; }
        }

        public string LastName
        {
            get { return Person.LastName; }
            set { Person.LastName = value; }
        }

        // ...
    }

}
