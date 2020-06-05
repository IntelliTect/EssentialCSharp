// Add readonly modifier ignored pending introduction of the concept
#pragma warning disable IDE0044
#pragma warning disable 649 // _Id is never assigned

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_31
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
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

// FirstName&LastName set inside Id property setter.
#pragma warning disable CS8618
        public Employee(int id) => Id = id;
#pragma warning restore CS8618

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
        [System.Diagnostics.CodeAnalysis.NotNull]
        [System.Diagnostics.CodeAnalysis.DisallowNull]
        public string FirstName { get; set; }
        [System.Diagnostics.CodeAnalysis.DisallowNull]
        [System.Diagnostics.CodeAnalysis.NotNull]
        public string LastName { get; set; }
        public string? Salary { get; set; } = "Not Enough";


        // ...
    }
}
