// Non-nullable field is uninitialized. Consider declaring as nullable.
#pragma warning disable CS8618

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_16
{
    public class Employee
    {
        private string FirstName;
        // FirstName getter
        public string GetFirstName()
        {
            return FirstName;
        }
        // FirstName setter
        public void SetFirstName(string newFirstName)
        {
            if(newFirstName != null && newFirstName != "")
            {
                FirstName = newFirstName;
            }
        }

        private string LastName;
        // LastName getter
        public string GetLastName()
        {
            return LastName;
        }
        // LastName setter
        public void SetLastName(string newLastName)
        {
            if(newLastName != null && newLastName != "")
            {
                LastName = newLastName;
            }
        }
        // ...
    }
}
