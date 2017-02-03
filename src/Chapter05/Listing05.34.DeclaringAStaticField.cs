namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_34
{
    class Employee
    {
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = NextId;
            NextId++;
        }

        // ...

        public static int NextId;

        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Salary { get; set; } = "Not Enough";

        // ...
    }
}
