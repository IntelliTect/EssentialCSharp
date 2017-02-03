namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_12
{
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
        // named with the Employee name.
        public static void Store(Employee employee)
        {
            // ...
        }
    }
}
