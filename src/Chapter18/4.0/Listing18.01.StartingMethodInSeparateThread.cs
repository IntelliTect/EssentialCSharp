namespace AddisonWesley.Michaelis.EssentialCSharp.Shared.Listing18_01
{
    using System;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            const int repetitions = 10000;
            Task task = new Task(() =>
            {
                for (int count = 0; count < repetitions; count++)
                {
                    Console.Write('-');
                }
            });

            task.Start();
            for (int count = 0; count < repetitions; count++)
            {
                Console.Write('.');
            }

            // Wait until the Task completes
            task.Wait();
        }
    }
}
