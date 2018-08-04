//namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_06
//{
//    using System;
//    using System.Runtime.Serialization;

//    // Supporting serialization via an attribute
//    [Serializable]
//    class DatabaseException : System.ApplicationException
//    {
//        // ...

//        // Used for deserialization of exceptions
//        public DatabaseException(
//            SerializationInfo serializationInfo,
//            StreamingContext context)
//        {
//            //...
//        }
//    }
//}