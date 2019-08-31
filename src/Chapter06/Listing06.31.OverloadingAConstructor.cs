namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_31
{
#pragma warning disable 649 // _Id is never assigned
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
#pragma warning restore 649
}
