namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_09
{
    using System;
    using System.Reflection;
    using System.Threading;

    class Program
    {
        public static void Main()
        {
            // Indicates whether this is the first
            // application instance.
            bool firstApplicationInstance;

            // Obtain the mutex name from the full 
            // assembly name.
            string mutexName =
                Assembly.GetEntryAssembly().FullName;

            using(Mutex mutex = new Mutex(false, mutexName,
                 out firstApplicationInstance))
            {

                if(!firstApplicationInstance)
                {
                    Console.WriteLine(
                        "This application is already running.");
                }
                else
                {
                    Console.WriteLine("ENTER to shut down");
                    Console.ReadLine();
                }
            }
        }
    }
}
