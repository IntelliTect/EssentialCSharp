namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_15
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
            // accessed from outside the class.
            // Console.WriteLine(
            //    ("Password = {0}", employee.Password);
        }
        // ...
    }

    class Employee
    {
        public string FirstName;
        public string LastName;
        public string Salary;
        private string Password;
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
