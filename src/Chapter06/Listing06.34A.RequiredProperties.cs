#if NET7_0_OR_GREATER
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_34A
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    public class Program
    {
        public static void Main()
        {
            Employee employee = new("Inigo Montoya");

            System.Console.WriteLine(employee.Name);

            // ...
        }
    }
    #region INCLUDE
    public class Employee
    {
        [SetsRequiredMembers]
        public Employee(string name)
        {
            #region HIGHLIGHT
            Name = name;
            #endregion HIGHLIGHT
        }

        required public string Name
        {
            #region HIGHLIGHT
            get => _Name!;
            #endregion HIGHLIGHT
            set => _Name =
                #region HIGHLIGHT
                value ?? throw new ArgumentNullException(nameof(value));
            #endregion HIGHLIGHT
        }
        private string? _Name;
        // ...
    }
    #endregion INCLUDE
}
#endif // NET7_0_OR_GREATER