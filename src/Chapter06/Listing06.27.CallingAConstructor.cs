namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_27
{
    using Listing06_26;

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
