namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_12
{
// In a completed Employee implementation FirstName, LastName
// and salary would be accessed
#pragma warning disable CS0649
    public class Employee
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
