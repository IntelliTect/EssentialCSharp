namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_28
{
    using Listing06_26;
// We dont use our declared employee
#pragma warning disable CS0168
    class Program
    {
        static void Main()
        {
            Employee employee;
            // ERROR: No overload because method 'Employee' 
            // takes '0' arguments
            //employee = new Employee();

            // ...
        }
    }
#pragma warning restore CS0168
}
