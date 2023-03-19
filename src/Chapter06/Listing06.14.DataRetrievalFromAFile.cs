// Non-nullable field is uninitialized. Consider declaring as nullable.
#pragma warning disable CS8618

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_14;

#region INCLUDE
using System;
// IO namespace
using System.IO;

public class Employee
{
    #region EXCLUDE
    public string FirstName;
    public string LastName;
    public string? Salary;

    public string GetName()
    {
        return $"{ FirstName } { LastName }";
    }

    public void SetName(string newFirstName, string newLastName)
    {
        this.FirstName = newFirstName;
        this.LastName = newLastName;
        Console.WriteLine(
            $"Name changed to '{ this.GetName() }'");
    }

    public void Save()
    {
        DataStorage.Store(this);
    }
    #endregion EXCLUDE
}

public class DataStorage
{
    #region EXCLUDE
    // Save an employee object to a file 
    // named with the Employee name
    // Error handling not shown
    public static void Store(Employee employee)
    {
        // Instantiate a FileStream using FirstNameLastName.dat
        // for the filename. FileMode.Create will force
        // a new file to be created or override an
        // existing file.
        // Note: This code could be improved with a using
        // statement — a construct that we have avoided because
        // it has not yet been introduced.
        FileStream stream = new(
            employee.FirstName + employee.LastName + ".dat",
            FileMode.Create);

        // Create a StreamWriter object for writing text
        // into the FileStream
        StreamWriter writer = new(stream);

        // Write all the data associated with the employee
        writer.WriteLine(employee.FirstName);
        writer.WriteLine(employee.LastName);
        writer.WriteLine(employee.Salary);

        // Dispose the StreamWriter and its stream
        writer.Dispose();  // Automatically closes the stream
    }
    #endregion EXCLUDE

    public static Employee Load(string firstName, string lastName)
    {
        Employee employee = new();

        // Instantiate a FileStream using FirstNameLastName.dat
        // for the filename. FileMode.Open will open
        // an existing file or else report an error
        FileStream stream = new(
            firstName + lastName + ".dat", FileMode.Open);

        // Create a StreamReader for reading text from the file
        StreamReader reader = new(stream);

        // Read each line from the file and place it into
        // the associated property.
        employee.FirstName = reader.ReadLine()??
            throw new InvalidOperationException(
                "FirstName cannot be null");
        employee.LastName = reader.ReadLine()??
            throw new InvalidOperationException(
                "LastName cannot be null");
        employee.Salary = reader.ReadLine();

        // Dispose the StreamReader and its Stream
        reader.Dispose();  // Automatically closes the stream

        return employee;
    }
}

public class Program
{
    public static void Main()
    {
        Employee employee1;

        Employee employee2 = new();
        employee2.SetName("Inigo", "Montoya");
        employee2.Save();

        // Modify employee2 after saving
        IncreaseSalary(employee2);

        // Load employee1 from the saved version of employee2
        employee1 = DataStorage.Load("Inigo", "Montoya");

        Console.WriteLine(
            $"{ employee1.GetName() }: { employee1.Salary }");
    }
    #region EXCLUDE
    public static void IncreaseSalary(Employee employee)
    {
        employee.Salary = "Enough to survive on";
    }
    #endregion EXCLUDE
}
#endregion INCLUDE
