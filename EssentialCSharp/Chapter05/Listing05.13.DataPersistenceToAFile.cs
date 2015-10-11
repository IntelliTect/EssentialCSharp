namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_13
{
    // IO namespace
    using System.IO;
    using Listing05_12;

    class DataStorage
    {
        // Save an employee object to a file 
        // named with the Employee name.
        // Error handling not shown.
        public static void Store(Employee employee)
        {
            // Instantiate a FileStream using FirstNameLastName.dat
            // for the filename. FileMode.Create will force
            // a new file to be created or override an
            // existing file.
            FileStream stream = new FileStream(
                employee.FirstName + employee.LastName + ".dat",
                FileMode.Create);

            // Create a StreamWriter object for writing text
            // into the FileStream.
            StreamWriter writer = new StreamWriter(stream);

            // Write all the data associated with the employee.
            writer.WriteLine(employee.FirstName);
            writer.WriteLine(employee.LastName);
            writer.WriteLine(employee.Salary);

            // Close the StreamWriter and its stream.
            writer.Close();  // Automatically closes the stream
        }
        // ...
    }
}
