// Non-nullable field is uninitialized. Consider declaring as nullable.
#pragma warning disable CS8618 // Pending a constructors

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_23
{
    class Program
    {
        static void Main()
        {
            Employee employee1 = new Employee();
            employee1.Initialize(42);
            // ERROR: The property or indexer 'Employee.Id' 
            // cannot be used in this context because the set 
            // accessor is inaccessible
            // employee1.Id = "490";                     //will not compile if you uncomment this line
        }
    }

    class Employee
    {
        public void Initialize(int id)
        {
            // Set Id property
            Id = id.ToString();
        }

        // ...
        // Id property declaration
        public string Id
        {
            get => _Id;
            private set => _Id = value;
        }
        private string _Id;
    }
}
