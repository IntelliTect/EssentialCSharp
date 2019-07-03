namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_09
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

        public void SetName(
            string newFirstName, string newLastName)
        {
            this.FirstName = newFirstName;
            this.LastName = newLastName;
        }
    }
#pragma warning restore CS0649
}
