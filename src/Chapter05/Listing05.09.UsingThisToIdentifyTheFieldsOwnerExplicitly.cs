namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_09
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

        public void SetName(
            string newFirstName, string newLastName)
        {
            this.FirstName = newFirstName;
            this.LastName = newLastName;
        }
    }
}
