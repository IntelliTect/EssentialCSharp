
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_35
{
    using System;

    public class Employee
    {
        public Employee(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public string Name { get; }
        // ...
    }
}
