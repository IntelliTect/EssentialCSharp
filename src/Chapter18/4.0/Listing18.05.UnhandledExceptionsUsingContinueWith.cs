namespace AddisonWesley.Michaelis.EssentialCSharp.Shared.Listing18_05
{
    using System;
    using System.Diagnostics;
    using System.Threading.Tasks;

    public class Program
    {
        public static void ChapterMain()
        {
            bool parentTaskFaulted = false;
            Task task = new Task(() =>
            {
                throw new Exception();
            });
            Task faultedTask = task.ContinueWith(
                (parentTask) =>
                {
                    parentTaskFaulted = parentTask.IsFaulted;
                }, TaskContinuationOptions.OnlyOnFaulted);
            task.Start();
            faultedTask.Wait();
            if (!task.IsFaulted)
            {
                task.Wait();
            }
            else
            {
                Console.WriteLine(
                    "ERROR: {0}", task.Exception.Message);
            }
        }
    }
}
