namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_33
{
    public class Program
    {
        public static void Main()
        {
            System.Console.WriteLine("No output in this example");
        }
    }

    #region INCLUDE
    public class Employee
    {
        // FirstName&LastName set inside Initialize() method.
        #pragma warning disable CS8618
        public Employee(string firstName, string lastName)
        {
            int id;
            // Generate an employee ID...
            #region EXCLUDE
            id = 0; // id needs to be initialized for this example
            #endregion
            #region HIGHLIGHT
            Initialize(id, firstName, lastName);
            #endregion
        }

        public Employee(int id, string firstName, string lastName)
        {
            #region HIGHLIGHT
            Initialize(id, firstName, lastName);
            #endregion
        }

        public Employee(int id)
        {
            string firstName;
            string lastName;
            Id = id;

            // Look up employee data
            #region EXCLUDE
            firstName = string.Empty;
            lastName = string.Empty;
            #endregion

            #region HIGHLIGHT
            Initialize(id, firstName, lastName);
            #endregion
        }
        #pragma warning restore CS8618

        #region HIGHLIGHT
        private void Initialize(
            int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
        #endregion
        #region EXCLUDE

        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Salary { get; set; } = "Not Enough";
        public string? Title { get; set; }
        public Employee? Manager { get; set; }

        // Name property
        public string Name
        {
            get
            {
                return FirstName + " " + LastName;
            }
            set
            {
                // Split the assigned value into 
                // first and last names
                string[] names;
                names = value.Split(new char[] { ' ' });
                if(names.Length == 2)
                {
                    FirstName = names[0];
                    LastName = names[1];
                }
                else
                {
                    // Throw an exception if the full 
                    // name was not assigned
                    throw new System.ArgumentException(
                        $"Assigned value '{value}' is invalid");
                }
            }
        }
        #endregion
    }
    #endregion
}
