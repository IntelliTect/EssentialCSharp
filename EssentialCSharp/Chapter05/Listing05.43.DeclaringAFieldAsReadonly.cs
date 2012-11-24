namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_43
{
    class Employee
    {
        public Employee(int id)
        {
            Id = id;
        }

        // ...
        public readonly int Id;
        public void SetId(int newId)
        {
            // ERROR:  read-only fields cannot be set
            //         outside the constructor.
            // Id = newId;
        }

        // ...
    }
}
