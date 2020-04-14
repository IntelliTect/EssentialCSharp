// Variable is declared but never used
#pragma warning disable CS0168 

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_28
{
    using Listing06_26;

    class Program
    {
        static void Main()
        {
            Employee employee;

            // ERROR: No overload because method 'Employee' 
            // takes '0' arguments
            // employee = new Employee();

            // ...
        }
    }
}
