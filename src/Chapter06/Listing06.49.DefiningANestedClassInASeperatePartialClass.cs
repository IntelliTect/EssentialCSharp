namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_49
{
    using System;
// In a fully implemented Person class, PersonId would be unique for every person
#pragma warning disable CS0169

    // File: Person.Designer.cs
    public partial class Person
    {
        #region Extensibility Method Definitions
        partial void OnLastNameChanging(string value);
        partial void OnFirstNameChanging(string value);
        #endregion

        // ...
        public System.Guid PersonId { get; set; }
        private System.Guid _PersonId;

        // ...
        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                if((_LastName != value))
                {
                    OnLastNameChanging(value);
                    _LastName = value;
                }
            }
        }
        private string _LastName;

        // ...
        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                if((_FirstName != value))
                {
                    OnFirstNameChanging(value);
                    _FirstName = value;
                }
            }
        }
        private string _FirstName;

    }

    // File: Person.cs
    partial class Person
    {
        partial void OnLastNameChanging(string value)
        {
            if(value == null)
            {
                // In C# 6.0 replace "value" with nameof(value)
                throw new ArgumentNullException("value");
            }
            if(value.Trim().Length == 0)
            {
                // In C# 6.0 replace "value" with nameof(value)
                throw new ArgumentException(
                "LastName cannot be empty.",
                    "value");
            }
        }

        partial void OnFirstNameChanging(string value)
        {
            if(value == null)
            {
                // In C# 6.0 replace "value" with nameof(value)
                throw new ArgumentNullException("value");
            }
            if (value.Trim().Length == 0)
            {
                // In C# 6.0 replace "value" with nameof(value)
                throw new ArgumentException(
                    "FirstName cannot be empty.",
                    "value");

            }
        }
    }
#pragma warning restore CS0169
}
