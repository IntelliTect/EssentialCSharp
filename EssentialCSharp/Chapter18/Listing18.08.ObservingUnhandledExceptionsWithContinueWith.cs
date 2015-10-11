﻿namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_08
{
    using System;
    using System.Diagnostics;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            bool parentTaskFaulted = false;
            Task task = new Task(() =>
                {
                    throw new InvalidOperationException();
                });
            Task continuationTask = task.ContinueWith(
                (antecedentTask) =>
                {
                    parentTaskFaulted =
                        antecedentTask.IsFaulted;
                }, TaskContinuationOptions.OnlyOnFaulted);
            task.Start();
            continuationTask.Wait();
            Trace.Assert(parentTaskFaulted);
            Trace.Assert(task.IsFaulted);
            task.Exception.Handle(eachException =>
            {
                Console.WriteLine(
                    $"ERROR: { eachException.Message }");
                return true;
            });
        }
    }
}
