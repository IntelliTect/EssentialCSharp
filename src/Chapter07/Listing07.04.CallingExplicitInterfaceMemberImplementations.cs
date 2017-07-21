﻿namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_04
{
    using System;
    using Listing07_02;

    public class Program
    {
        public static void Main()
        {
            string[] values;
            Contact contact1, contact2 = null;

            // ...

            // ERROR:  Unable to call ColumnValues() directly
            //         on a contact.
            // values = contact1.ColumnValues;

            // First cast to IListable.
            values = ((IListable)contact2).ColumnValues;
            // ...
        }
    }

    public class Contact : PdaItem, IListable, IComparable
    {
        // ...
        public Contact(string name)
            : base(name)
        {
        }

        #region IComparable Members
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>
        /// Less than zero:      This instance is less than obj. 
        /// Zero                 This instance is equal to obj. 
        /// Greater than zero    This instance is greater than obj. 
        /// </returns>
        public int CompareTo(object obj)
        {
            int result;
            Contact contact = obj as Contact;

            if(obj == null)
            {
                // This instance is greater than obj. 
                result = 1;
            }
            else if(obj.GetType() != typeof(Contact))
            {
                // Use C# 6.0 nameof operator in message to
                // ensure consistency in the Type name.
                throw new ArgumentException(
                    $"The parameter is not a of type { nameof(Contact) }",
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

        protected string LastName { get; set; }
        protected string FirstName { get; set; }
        protected string Phone { get; set; }
        protected string Address { get; set; }
    }
}