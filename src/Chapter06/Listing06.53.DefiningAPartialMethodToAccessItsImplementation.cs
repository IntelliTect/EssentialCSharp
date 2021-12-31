// Non-nullable field is uninitialized. Consider declaring as nullable.
#pragma warning disable CS8618 // Pending a constructors

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_53
{
    using System;

    // File: Person.Designer.cs
    public partial class Person
    {
        #region Extensibility Method Definitions
        static partial void OnLastNameChanging(string value);
        static partial void OnFirstNameChanging(string value);
        #endregion

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
                if(_FirstName != value)
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
        static partial void OnLastNameChanging(string value)
        {
            if(value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            if(value.Trim().Length == 0)
            {
                throw new ArgumentException(
                "LastName cannot be empty.",
                    nameof(value));
            }
        }

        static partial void OnFirstNameChanging(string value)
        {
            if(value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            if (value.Trim().Length == 0)
            {
                throw new ArgumentException(
                    "FirstName cannot be empty.",
                    nameof(value));

            }
        }
    }
}
