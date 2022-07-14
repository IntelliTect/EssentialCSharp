// Non-nullable field is uninitialized. Consider declaring as nullable.
#pragma warning disable CS8618

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_10
{
    #region INCLUDE
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string? Salary;

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
    #endregion INCLUDE
}