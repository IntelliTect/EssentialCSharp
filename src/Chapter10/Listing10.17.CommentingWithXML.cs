using Chapter10;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_17
{
    /// <summary>
    /// DataStorage is used to persist and retrieve
    /// employee data from the files.
    /// </summary>
    class DataStorage
    {
        /// <summary>
        /// Save an employee object to a file
        /// named with the Employee name.
        /// </summary>
        /// <remarks>
        /// This method uses <seealso cref="System.IO.FileStream"/>
        /// in addition to
        /// <seealso cref="System.IO.StreamWriter"/>
        /// </remarks>
        /// <param name="employee">
        /// The employee to persist to a file</param>
        /// <date>January 1, 2000</date>
        public static void Store(Employee employee)
        {
            // ...
        }

        /** <summary>
         * Loads up an employee object.
         * </summary>
         * <remarks>
         * This method uses <seealso cref="System.IO.FileStream"/>
         * in addition to
         * <seealso cref="System.IO.StreamReader"/>
         * </remarks>
         * <param name="firstName">
         * The first name of the employee</param>
         * <param name="lastName">
         * The last name of the employee</param>
         * <returns>
         * The employee object corresponding to the names
         * </returns>
         * <date>January 1, 2000</date> **/
        public static Employee Load(string firstName, string lastName)
        {
            // ...
            return new Employee();
        }
    }

    class Program
    {
        // ...
    }
}