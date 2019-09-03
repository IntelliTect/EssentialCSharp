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
        public int CompareTo(object obj)
        {
            int result;
            Contact contact = obj as Contact;

            if(obj == null)
            {
                // This instance is greater than obj 
                result = 1;
            }
            else if(obj.GetType() != typeof(Contact))
            {
                // Use C# 6.0 nameof operator in message to
                // ensure consistency in the Type name
                throw new ArgumentException(
                    $"The parameter is not a value of type { nameof(Contact) }",
                    nameof(obj));
            }
            else if(Contact.ReferenceEquals(this, obj))
            {
                result = 0;
            }
            else
            {
                result = LastName.CompareTo(contact.LastName);
                if(result == 0)
                {
                    result = FirstName.CompareTo(contact.FirstName);
                }
            }
            return result;
        }
        #endregion

        #region IListable Members
        string[] IListable.ColumnValues
        {
            get
            {
                return new string[] 
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
                if(names.Length == 2)
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
        
        protected string LastName { get; set; }
        protected string FirstName { get; set; }
        protected string Phone { get; set; }
        protected string Address { get; set; }
    }
}
