// Justification: Only a aartial implmentation provided for elucidation purposes.
#pragma warning disable IDE0059 // Unnecessary assignment of a value

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_04
{
    using System;
    using Listing08_02;

    public class Program
    {
        public static void Main()
        {
            string?[] values;
            Contact contact = new Contact("Inigo Montoya");

            // ...

            // ERROR:  Unable to call .CellValues directly
            //         on a contact
            // values = contact.CellValues;

            // First cast to IListable
            values = ((IListable)contact).CellValues;

            // ...
        }
    }

    public class Contact : PdaItem, IListable
    {
        // ...
        public Contact(string name)
            : base(name)
        {
        }

        #region IListable Members
        string?[] IListable.CellValues
        {
            get
            {
                return new string?[] 
          {
              FirstName,
              LastName,
              Phone,
              Address
          };
            }
        }
        #endregion

        private string? _LastName;
        protected string LastName
        {
            get => _LastName!;
            set => _LastName = value ?? throw new ArgumentNullException(nameof(value));
        }

        private string? _FirstName;
        protected string FirstName
        {
            get => _FirstName!;
            set => _FirstName = value ?? throw new ArgumentNullException(nameof(value));
        }
        protected string? Phone { get; set; }
        protected string? Address { get; set; }
        static public string GetName(string firstName, string lastName)
            => $"{ firstName } { lastName }";
    }
}