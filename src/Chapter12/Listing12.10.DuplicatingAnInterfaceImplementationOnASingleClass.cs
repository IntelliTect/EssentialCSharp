namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_10
{
    using System.Collections.Generic;

    public interface IContainer<T>
    {
        ICollection<T> Items
        {
            get;
            set;
        }
    }

    public class Person : IContainer<Address>,
        IContainer<Phone>, IContainer<Email>
    {
        ICollection<Address> IContainer<Address>.Items
        {
            get
            {
                //...
                return new List<Address>();
            }
            set
            {
                //...
            }
        }
        ICollection<Phone> IContainer<Phone>.Items
        {
            get
            {
                //...
                return new List<Phone>();
            }
            set
            {
                //...
            }
        }
        ICollection<Email> IContainer<Email>.Items
        {
            get
            {
                //...
                return new List<Email>();
            }
            set
            {
                //...
            }
        }
    }

    public class Address { } // For example purposes only
    public class Phone { } // For example purposes only
    public class Email { } // For example purposes only
}
