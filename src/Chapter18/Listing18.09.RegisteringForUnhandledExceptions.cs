// Unhandled exceptions will be added in version 1.1 of .Net Core

//namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_09
//{
//    using System;
//    using System.Diagnostics;
//    using System.Threading;

//    public class Program
//    {
//        public static Stopwatch clock = new Stopwatch();
//        public static void ChapterMain()
//        {
//            try
//            {
//                clock.Start();
//                // Register a callback to receive notifications
//                // of any unhandled exception.
//                AppDomain.CurrentDomain.UnhandledException +=
//                  (s, e) =>
//                  {
//                      Message("Event handler starting");
//                      Delay(4000);
//                  };

//                Thread thread = new Thread(() =>
//                {
//                    Message("Throwing exception.");
//                    throw new Exception();
//                });
//                thread.Start();

//                Delay(2000);
//            }
//            finally
//            {
//                Message("Finally block running.");
//            }
//        }

//        static void Delay(int i)
//        {
//            Message($"Sleeping for {i} ms");
//            Thread.Sleep(i);
//            Message("Awake");
//        }

//        static void Message(string text)
//        {
//            Console.WriteLine("{0}:{1:0000}:{2}",
//              Thread.CurrentThread.ManagedThreadId,
//                    clock.ElapsedMilliseconds,
//              text);
//        }
//    }
//}
