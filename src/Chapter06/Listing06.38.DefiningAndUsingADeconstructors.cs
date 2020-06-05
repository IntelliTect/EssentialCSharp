namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_38
{
    public class Program
    {
        public static void Main()
        {
            Employee employee;
            employee = new Employee("Inigo", "Montoya")
            {
                // Leveraging object initializer syntax
                Salary = "Too Little"
            };

            System.Console.WriteLine(
                "{0} {1}: {2}",
                employee.FirstName,
                employee.LastName,
                employee.Salary);
#if !PRECSHARP7
            employee.Deconstruct(out _, out string firstName, 
                out string lastName, out string? salary);
#else
            int id;
            string firstName, lastName, salary;
            employee.Deconstruct(out id, out firstName, 
                out lastName, out salary);
#endif
            System.Console.WriteLine(
                "{0} {1}: {2}",
                firstName, lastName, salary);

            (_, firstName, lastName, salary) = employee;

            System.Console.WriteLine(
                "{0} {1}: {2}",
                firstName, lastName, salary);

        }
    }

    class Employee
    {
        // FirstName&LastName set inside Initialize() method.
        #pragma warning disable CS8618
        public Employee(string firstName, string lastName)
        {
            int id;
            // Generate an employee ID...
            id = 0; // id needs to be initialized for this example
            // ...
            Initialize(id, firstName, lastName);
        }

        public Employee(int id, string firstName, string lastName)
        {
            Initialize(id, firstName, lastName);
        }

        public Employee(int id)
        {
            string firstName;
            string lastName;
            Id = id;

            // Look up employee data
            firstName = string.Empty;
            lastName = string.Empty;
            // ...

            Initialize(id, firstName, lastName);
        }
        #pragma warning disable CS8618

        private void Initialize(
            int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public void Deconstruct(
            out int id, out string firstName, 
            out string lastName, out string? salary)
        {
           (id, firstName, lastName, salary) = 
                (Id, FirstName, LastName, Salary);
        }
        // ...


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
                // first and last names.
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
                    // name was not assigned.
                    throw new System.ArgumentException(
                        $"Assigned value '{value}' is invalid");
                }
            }
        }
    }
}
