// Variable is declared but never used
#pragma warning disable CS0168 

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_28
{
    using Listing06_26;

    #region INCLUDE
    public class Program
    {
        public static void Main()
        {
            Employee employee;

            #region HIGHLIGHT
            // ERROR: No overload because method 'Employee' 
            // takes '0' arguments
            // employee = new Employee();
            #endregion HIGHLIGHT

            // ...
        }
    }
    #endregion INCLUDE
}
