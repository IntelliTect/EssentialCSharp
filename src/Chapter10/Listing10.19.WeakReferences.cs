namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_19
{
    using System;
    using System.IO;
#pragma warning disable CS0649

    public class Program
    {
        private WeakReference Data;

        public FileStream GetData()
        {
            FileStream data = (FileStream)Data.Target;

            if(data != null)
            {
                return data;
            }
            else
            {
                // Load data
                // ...

                // Create a weak reference
                // to data for use later
                Data.Target = data;
            }
            return data;
        }

        public static void Main()
        {
            Console.WriteLine("No output in this example.");
        }
    }
#pragma warning restore CS0649
}