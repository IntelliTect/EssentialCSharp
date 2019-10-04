namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_31
{
#pragma warning disable CS0649 // Id would be assigned to in a full implementation

    public class Employee
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

        public Employee(int id) => Id = id;

        private int _Id;
        public int Id
        {
            get => _Id;
            private set
            {
                // Look up employee name...
                // ...
            }
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Salary { get; set; } = "Not Enough";


        // ...
    }

#pragma warning restore CS0649 // Id would be assigned to in a full implementation
}
