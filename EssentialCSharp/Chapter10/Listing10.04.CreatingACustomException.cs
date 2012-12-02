namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_04
{
    using System;

    class DatabaseException : System.Exception
    {
        //public DatabaseException(
        //    System.Data.SqlClient.SQLException exception)
        //{
        //    InnerException = exception;
        //    // ...
        //}

        //public DatabaseException(
        //    System.Data.OracleClient.OracleException exception)
        //{
        //    InnerException = exception;
        //    // ...
        //}

        public DatabaseException()
        {
            // ...
        }

        public DatabaseException(string message)
        {
            // ...
        }

        public DatabaseException(
            string message, Exception innerException)
        {
            //InnerException = innerException;
            // ...
        }
    }
}