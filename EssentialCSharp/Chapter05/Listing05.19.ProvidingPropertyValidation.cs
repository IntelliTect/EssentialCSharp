using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_19
{
    class Employee
    {
        // ...
        public void Initialize(
            string newFirstName, string newLastName)
        {
            // Use property inside the Employee
            // class as well.
            FirstName = newFirstName;
            LastName = newLastName;
        }

        // LastName property
        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                // Validate LastName assignment
                if (value == null)
                {
                    // Report error
                    throw new ArgumentNullException();
                }
                else
                {
                    // Remove any whitespace around
                    // the new last name.
                    value = value.Trim();
                    if (value == "")
                    {
                        throw new ArgumentException(
                            "LastName cannot be blank.");
                    }
                    else
                        _LastName = value;
                }
            }
        }
        private string _LastName;

        // FirstName property
        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                // Validate FirstName assignment
                if (value == null)
                {
                    // Report error
                    throw new ArgumentNullException();
                }
                else
                {
                    // Remove any whitespace around
                    // the new last name.
                    value = value.Trim();
                    if (value == "")
                    {
                        throw new ArgumentException(
                            "FirstName cannot be blank.");
                    }
                    else
                        _FirstName = value;
                }
            }
        }
        private string _FirstName;
    }
}
