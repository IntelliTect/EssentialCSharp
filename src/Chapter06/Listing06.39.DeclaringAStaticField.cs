namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_39
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
        public string? Salary { get; set; } = "Not Enough";

        // ...
    }
}
