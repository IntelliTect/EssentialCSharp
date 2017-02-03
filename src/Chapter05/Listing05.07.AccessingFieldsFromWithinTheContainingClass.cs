namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_07
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
    }
}
