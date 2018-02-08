namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_26
{
    using Listing05_25;

    public class Program
    {
        public static void Main()
        {
            Employee employee;
            employee = new Employee("Inigo", "Montoya");
            employee.Salary = "Too Little";

            System.Console.WriteLine(
                "{0} {1}: {2}",
                employee.FirstName,
                employee.LastName,
                employee.Salary);
        }
        // ...
    }
}
