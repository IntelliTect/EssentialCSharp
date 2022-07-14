// Non-nullable field is uninitialized. Consider declaring as nullable.
#pragma warning disable CS8618 // Pending a constructors

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_21
{
    #region INCLUDE
    public class Program
    {
        public static void Main()
        {
            Employee employee1 = new Employee();
            employee1.Initialize(42);

            #region HIGHLIGHT
            // ERROR:  Property or indexer 'Employee.Id' 
            // cannot be assigned to; it is read-only
            // employee1.Id = "490";
            #endregion
        }
    }

    public class Employee
    {
        public void Initialize(int id)
        {
            #region HIGHLIGHT
            // Use field because Id property has no setter;
            // it is read-only
            _Id = id.ToString();
            #endregion
        }

        // ...
        // Id property declaration
        public string Id
        {
            get => _Id;
            #region HIGHLIGHT
            // No setter provided
            #endregion
        }
        private string _Id;
    }
    #endregion
}
