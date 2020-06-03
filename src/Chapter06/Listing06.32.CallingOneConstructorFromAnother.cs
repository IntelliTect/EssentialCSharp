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

        // FirstName&LastName set inside Id property setter.
        #pragma warning disable CS8618
        public Employee(int id)
        {
            Id = id;

            // Look up employee name...
            // ...

            // NOTE: Member constructors cannot be 
            // called explicitly inline
            // this(id, firstName, lastName);
        }
        #pragma warning restore CS8618

        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Salary { get; set; } = "Not Enough";

        // ...
    }
}
