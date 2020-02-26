namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_03
{
    using System;
    using Listing08_02;

    public class Contact : PdaItem, IListable, IComparable
    {
        // ...
        public Contact(string name)
            : base(name)
        {
            Name = name;
        }

        #region IComparable Members
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>
        /// Less than zero:      This instance is less than obj
        /// Zero                 This instance is equal to obj 
        /// Greater than zero    This instance is greater than obj 
        /// </returns>
        public int CompareTo(object? obj) => obj switch
        {
            null => 1,
            Contact contact when ReferenceEquals(this, obj) => 0,
            Contact { LastName: string lastName } 
                when LastName.CompareTo(lastName) != 0 =>
                    LastName.CompareTo(lastName),
            Contact { FirstName: string firstName } 
                when FirstName.CompareTo(firstName) != 0 =>
                    FirstName.CompareTo(firstName),
            Contact _ => 0,
            _ => throw new ArgumentException(
                $"The parameter is not a value of type { nameof(Contact) }",
                nameof(obj))
        };
        #endregion

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

        public override string Name
        {
            get
            {
                return FirstName + " " + LastName;
            }
            set
            {
                // Split the assigned value into 
                // first and last names
                string[] names;
                names = value.Split(new char[] { ' ' });
                if (names.Length == 2)
                {
                    FirstName = names[0];
                    LastName = names[1];
                }
                else
                {
                    // Throw an exception if the full 
                    // name was not assigned
                    throw new System.ArgumentException(
                        $"Assigned value '{value}' is invalid");
                }
            }
        }

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
            set => _FirstName = value??throw new ArgumentNullException( nameof(value)); 
        }
        protected string? Phone { get; set; }
        protected string? Address { get; set; }
        static public string GetName(string firstName, string lastName)
            => $"{ firstName } { lastName }";
    }
}
