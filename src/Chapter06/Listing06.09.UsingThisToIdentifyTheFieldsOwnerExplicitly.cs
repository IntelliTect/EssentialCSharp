// Non-nullable field is uninitialized. Consider declaring as nullable.
#pragma warning disable CS8618

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_09
{
    
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string? Salary;

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
