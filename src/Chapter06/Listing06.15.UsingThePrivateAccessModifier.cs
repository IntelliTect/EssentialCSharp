// Non-nullable field is uninitialized. Consider declaring as nullable.
#pragma warning disable CS8618
// Our Main doesn't leverage everything in our Employee implementation - in production it would
#pragma warning disable CS0649
// Disabled pending introductin to object initializers
#pragma warning disable IDE0017 
// Add readonly modifier ignored pending introduction of the concept
#pragma warning disable IDE0044


namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_15
{
    public class Program
    {
        public static void Main()
        {
            Employee employee = new Employee();

            employee.FirstName = "Inigo";
            employee.LastName = "Montoya";

            // ...

            // Password is private, so it cannot be
            // accessed from outside the class
            // Console.WriteLine(
            //    ("Password = {0}", employee.Password);
        }
        // ...
    }

    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string? Salary;
        // Working de-crypted passwords for elucidation 
        // only – this is no recommended.
        private string Password;  // Uninitialized pending explanation of constructors
        private bool IsAuthenticated;

        public bool Logon(string password)
        {
            if(Password == password)
            {
                IsAuthenticated = true;
            }
            return IsAuthenticated;
        }

        public bool GetIsAuthenticated()
        {
            return IsAuthenticated;
        }
        // ...
    }
}
