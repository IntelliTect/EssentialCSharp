namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_07
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
