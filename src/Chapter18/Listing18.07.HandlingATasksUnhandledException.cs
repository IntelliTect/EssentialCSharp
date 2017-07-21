﻿namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_07
{
    using System;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            // Use Task.Factory.StartNew<string>() for
            // TPL prior to .NET 4.5
            Task task = Task.Run(() =>
            {
                throw new InvalidOperationException();
            });

            try
            {
                task.Wait();
            }
            catch(AggregateException exception)
            {
                exception.Handle(eachException =>
                {
                    Console.WriteLine(
                        $"ERROR: { eachException.Message }");
                    return true;
                });
            }
        }
    }
}
