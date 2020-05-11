using System;
using System.Runtime.Serialization;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_04
{

    class DatabaseException : Exception
    {
        public DatabaseException(
            string? message,
            System.Data.SqlClient.SQLException? exception)
            : base(message, innerException: exception)
        {
            // ...
        }

        public DatabaseException(
            string? message,
            System.Data.OracleClient.OracleException? exception)
            : base(message, innerException: exception)
        {
            // ...
        }

        public DatabaseException()
        {
            // ...
        }

        public DatabaseException(string? message)
            : base(message)
        {
            // ...
        }

        public DatabaseException(
            string? message, Exception? exception)
            : base(message, innerException: exception)
        {
            // ...
        }

        // Used for deserialization of exceptions
        public DatabaseException(
            SerializationInfo serializationInfo,
            StreamingContext context)
            : base(serializationInfo, context)
        {
            //...
        }
    }

    // Create mock versions of the database exception classes rather
    // than referencing the real libraries.
#pragma warning disable CA1032 // Implement standard exception constructors
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
#pragma warning restore CA1032 // Implement standard exception constructors
}

