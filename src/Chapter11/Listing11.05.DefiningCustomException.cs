namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_05
{
    using System;
    using System.Data.OracleClient;
    using System.Data.SqlClient;

    class DatabaseException : System.Exception
    {
        public DatabaseException(
                                 System.Data.SqlClient.SQLException exception)
        {
            InnerException = exception;
            // ...
        }

        public DatabaseException(
                                 System.Data.OracleClient.OracleException exception)
        {
            InnerException = exception;
            // ...
        }

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
            InnerException = innerException;
            // ...
        }
    }
}
