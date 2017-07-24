// Unhandled exceptions will be added in version 1.1 of .Net Core

//namespace AddisonWesley.Michaelis.EssentialCSharp.Shared.Listing18_20
//{
//    using System;
//    using System.Threading;

//    public class Program
//    {
//        public static void Main()
//        {
//            try
//            {
//                // Register a callback to 
//                // receive notifications
//                // of any unhandled exception.
//                AppDomain.CurrentDomain.UnhandledException
//                    += OnUnhandledException;

//                ThreadPool.QueueUserWorkItem(
//                    state =>
//                    {
//                        throw new Exception(
//                            "Arbitrary Exception");
//                    });

//                // ...

//                // Wait for the unhandled exception to fire
//                // ADVANCED: Use ManualResetEvent to avoid 
//                // timing dependent code.
//                Thread.Sleep(10000);

//                Console.WriteLine("Still running...");
//            }
//            finally
//            {
//                Console.WriteLine("Exiting...");
//            }
//        }

//        static void OnUnhandledException(
//            object sender,
//            UnhandledExceptionEventArgs eventArgs)
//        {
//            Exception exception =
//                (Exception)eventArgs.ExceptionObject;
//            Console.WriteLine("ERROR ({0}):{1} ---> {2}",
//                 exception.GetType().Name,
//                exception.Message,
//                exception.InnerException.Message);
//        }

//        public static void ThrowException()
//        {
//            throw new Exception(
//                "Arbitrary exception");
//        }
//    }

//}
