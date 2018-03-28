namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_08
{
    public class PdaItem
    {
        // ...
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // ...
    }

    public class Contact : PdaItem
    {
        private Person InternalPerson { get; set; }

        public string FirstName
        {
            get { return InternalPerson.FirstName; }
            set { InternalPerson.FirstName = value; }
        }

        public string LastName
        {
            get { return InternalPerson.LastName; }
            set { InternalPerson.LastName = value; }
        }
        // ...
    }

}
