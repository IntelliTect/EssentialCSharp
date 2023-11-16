namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_26;

#if NET8_0_OR_GREATER
public class Program
{
    public static void Main()
    {
        Employee employee = new("Inigo", "Montoya")
        {
            Salary = "Too Little"
        };

        Console.WriteLine(
            $"{employee.FirstName} {employee.LastName}: {employee.Salary}");
    }
}

#region INCLUDE
#region HIGHLIGHT
// Employee constructor
public class Employee(string firstName, string lastName)
{
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
#endregion HIGHLIGHT
    public string? Salary { get; set; } = "Not Enough";

    #region EXCLUDE
    public string? Title { get; set; }
    public Employee? Manager { get; set; }

    // Name property
    public string FullName
    {
        get
        {
            return FirstName + " " + LastName;
        }
        set
        {
            // Split the assigned value into 
            // first and last names
            string[] names = value.Split(' ');
            if(names.Length == 2)
            {
                FirstName = names[0];
                LastName = names[1];
            }
            else
            {
                // Throw an exception if the full 
                // name was not assigned
                throw new ArgumentException(
                   $"Assigned value '{ value }' is invalid", 
                    nameof(value));
            }
        }
    }
    #endregion EXCLUDE
}
#endregion INCLUDE
#endif // NET8_0_OR_GREATER