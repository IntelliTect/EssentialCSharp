namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_43
{
    using Chapter08.Listing08_02;
    using Contact = Chapter12.Listing12_43_Dependencies.Contact;

    interface IReadOnlyPair<out T>
    {
        T First { get; }
        T Second { get; }
    }

    interface IPair<T>
    {
        T First { get; set; }
        T Second { get; set; }
    }

    public struct Pair<T> : IPair<T>, IReadOnlyPair<T>
    {
        public Pair(T first, T second)
        {
            _First = first;
            _ReadOnlyFirst = first;
            _Second = second;
            _ReadOnlySecond = second;
        }

        // ...

        T IPair<T>.First
        {
            get
            {
                return _First;
            }
            set
            {
                _First = value;
            }
        }
        private T _First;

        T IReadOnlyPair<T>.Second
        {
            get
            {
                return _ReadOnlySecond;
            }
        }
        private T _ReadOnlySecond;

        T IReadOnlyPair<T>.First
        {
            get
            {
                return _ReadOnlyFirst;
            }
        }
        private T _ReadOnlyFirst;

        T IPair<T>.Second
        {
            get
            {
                return _Second;
            }
            set
            {
                _Second = value;
            }
        }
        private T _Second;
    }

    class Program
    {
        static void Main()
        {
            // Allowed in C# 4.0
            Pair<Contact> contacts =
                new Pair<Contact>(
                    new Contact("Princess Buttercup"),
                    new Contact("Inigo Montoya"));
            IReadOnlyPair<PdaItem> pair = contacts;
            PdaItem pdaItem1 = pair.First;
            PdaItem pdaItem2 = pair.Second;
        }
    }

}


//Dependencies
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_43_Dependencies
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
