namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_09
{
    using System;
    using System.Threading;
    using System.Reflection;

    class Program
    {
        public static void Main()
        {
            // Indicates whether this is the first
            // application instance
            bool firstApplicationInstance;

            // Obtain the mutex name from the full 
            // assembly name.
            string mutexName =
                Assembly.GetEntryAssembly().FullName;

            using (Mutex mutex = new Mutex(false, mutexName,
                 out firstApplicationInstance))
            {

                if (!firstApplicationInstance)
                {
                    Console.WriteLine(
                        "This application is already running.");
                }
                else
                {
                    Console.WriteLine("ENTER to shutdown");
                    Console.ReadLine();
                }
            }
        }
    }
}
