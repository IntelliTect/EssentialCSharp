namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_16
{
    class Employee
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
