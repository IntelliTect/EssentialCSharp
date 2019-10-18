// Non-nullable field is uninitialized. Consider declaring as nullable.
#pragma warning disable CS8618 // Pending a constructors

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_21
{
    class Program
    {
        static void Main()
        {
            Employee employee1 = new Employee();
            employee1.Initialize(42);

            // ERROR:  Property or indexer 'Employee.Id' 
            // cannot be assigned to; it is read-only
            // employee1.Id = "490";
        }
    }

    class Employee
    {
        public void Initialize(int id)
        {
            // Use field because Id property has no setter;
            // it is read-only
            _Id = id.ToString();
        }

        // ...
        // Id property declaration
        public string Id
        {
            get => _Id;
            // No setter provided
        }
        private string _Id;

        public string ID => Id;

    }
}
