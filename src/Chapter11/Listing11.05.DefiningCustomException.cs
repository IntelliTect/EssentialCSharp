using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_05
{

    class DatabaseException : Exception
    {
        public DatabaseException(
            string message,
            System.Data.SqlClient.SQLException exception)
            : base(message, innerException: exception)
        {
            // ...
        }

        public DatabaseException(
            string message,
            System.Data.OracleClient.OracleException exception)
            : base(message, innerException: exception)
        {
            // ...
        }

        public DatabaseException()
        {
            // ...
        }

        public DatabaseException(string message)
            : base(message)
        {
            // ...
        }

        public DatabaseException(
            string message, Exception exception)
            : base(message, innerException: exception)
        {
            // ...
        }
    }

    // Create mock versions of the database exception classes rather
    // than referencing the real libraries.
    namespace System.Data
    {
        namespace SqlClient
        {
            class SQLException : Exception
            {
            }
        }
        namespace OracleClient
        {
            class OracleException : Exception
            {
            }
        }
    }
}


