namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_07
{
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
    }
#pragma warning restore CS0649
}
