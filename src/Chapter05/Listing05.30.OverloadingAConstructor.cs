namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_30
{
    class Employee
    {
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Employee(
            int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public Employee(int id)
        {
            Id = id;

            // Look up employee name...
            // ...
        }

        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Salary { get; set; } = "Not Enough";


        // ...
    }
}
