namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_32
{
    public class Employee
    {
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Employee(
            int id, string firstName, string lastName)
            : this(firstName, lastName)
        {
            Id = id;
        }

        public Employee(int id)
        {
            Id = id;

            // Look up employee name...
            // ...

            // NOTE: Member constructors cannot be 
            // called explicitly inline
            // this(id, firstName, lastName);
        }

        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Salary { get; set; } = "Not Enough";

        // ...
    }
}
