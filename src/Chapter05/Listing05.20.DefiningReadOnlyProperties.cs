namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_20
{
    class Program
    {
        static void Main()
        {
            Employee employee1 = new Employee();
            employee1.Initialize(42);

            // ERROR:  Property or indexer 'Employee.Id' 
            // cannot be assigned to; it is read-only.
            // employee1.Id = "490";
        }
    }

    class Employee
    {
        public void Initialize(int id)
        {
            // Use field because Id property has no setter;
            // it is read-only.
            _Id = id.ToString();
        }

        // ...
        // Id property declaration
        public string Id
        {
            get
            {
                return _Id;
            }
            // No setter provided.
        }
        private string _Id = default(string);

        public string ID => Id;

    }
}