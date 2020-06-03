namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_41
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Employee.NextId = 1000000;

            Employee employee1 = new Employee(
                "Inigo", "Montoya");
            Employee employee2 = new Employee(
                "Princess", "Buttercup");

            Console.WriteLine(
                "{0} {1} ({2})",
                employee1.FirstName,
                employee1.LastName,
                employee1.Id);
            Console.WriteLine(
                "{0} {1} ({2})",
                employee2.FirstName,
                employee2.LastName,
                employee2.Id);

            Console.WriteLine(
                $"NextId = {Employee.NextId}");
        }
    }

    public class Employee
    {
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = NextId;
            NextId++;
        }

        public static int NextId = 42;

        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Salary { get; set; } = "Not Enough";
    }
}
