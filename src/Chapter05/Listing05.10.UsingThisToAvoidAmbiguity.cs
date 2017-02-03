namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_10
{
    class Employee
    {
        public string FirstName;
        public string LastName;
        public string Salary;

        public string GetName()
        {
            return $"{ FirstName }  { LastName }";
        }

        // Caution:  Parameter names use PascalCase
        public void SetName(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
    }
}