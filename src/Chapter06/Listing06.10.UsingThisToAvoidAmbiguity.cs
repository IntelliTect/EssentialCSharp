namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_10
{
// Salary is used later in the Chapter as the implementation expands
#pragma warning disable CS0649
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
#pragma warning restore CS0649
}