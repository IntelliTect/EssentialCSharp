namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_12
{
// Salary is used later in the Chapter as the implementation expands
#pragma warning disable CS0649
    class Employee
    {
        public string FirstName;
        public string LastName;
        public string Salary;

        public void Save()
        {
            DataStorage.Store(this);
        }
    }

    class DataStorage
    {
        // Save an employee object to a file 
        // named with the Employee name
        public static void Store(Employee employee)
        {
            // ...
        }
    }
#pragma warning restore CS0649
}
