namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_06;

#region INCLUDE
using System;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        bool parentTaskFaulted = false;
        Task task = new(() =>
            {
                throw new InvalidOperationException();
            });
        #region HIGHLIGHT
        Task continuationTask = task.ContinueWith(
        #endregion HIGHLIGHT
            (antecedentTask) =>
            {
                parentTaskFaulted =
                    antecedentTask.IsFaulted;
            }, TaskContinuationOptions.OnlyOnFaulted);
        task.Start();
        #region HIGHLIGHT
        continuationTask.Wait();
        #endregion HIGHLIGHT
        if (!parentTaskFaulted)
        {
            throw new Exception("Parent task should be faulted");
        }
        if (!task.IsFaulted)
        {
            throw new Exception("Task should be faulted");
        }

        #region HIGHLIGHT
        task.Exception!.Handle(eachException =>
        #endregion HIGHLIGHT
        {
            Console.WriteLine(
                $"ERROR: { eachException.Message }");
            return true;
        });
    }
}
#endregion INCLUDE
