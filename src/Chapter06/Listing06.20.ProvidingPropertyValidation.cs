// Non-nullable field is uninitialized. Consider declaring as nullable.
#pragma warning disable CS8618

using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_20
{
    public class Employee
    {
        // ...
        public void Initialize(
            string newFirstName, string newLastName)
        {
            // Use property inside the Employee
            // class as well
            FirstName = newFirstName;
            LastName = newLastName;
        }

        // LastName property
        public string LastName
        {
            get => _LastName;
            set
            {
                // Validate LastName assignment
                if(value == null)
                {
                    // Report error
                    throw new ArgumentNullException(nameof(value));
                }
                else
                {
                    // Remove any whitespace around
                    // the new last name
                    value = value.Trim();
                    if(value == "")
                    {
                        throw new ArgumentException(
                            "LastName cannot be blank.", nameof(value));
                    }
                    else
                    {
                        _LastName = value;
                    }
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
                if(value == null)
                {
                    // Report error
                    // In C# 6.0 replace "value" with nameof(value)
                    throw new ArgumentNullException("value");
                }
                else
                {
                    // Remove any whitespace around
                    // the new last name
                    value = value.Trim();
                    if(value == "")
                    {
                        throw new ArgumentException(
                            // Use "value" rather than nameof(value)
                            // prior to C# 6.0.
                            "FirstName cannot be blank.", nameof(value));
                    }
                    else
                    {
                        _FirstName = value;
                    }
                }
            }
        }
        private string _FirstName;
    }
}
