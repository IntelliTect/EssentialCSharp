namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_07
{
    using System;
    using System.Threading.Tasks;

    public static class Program
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
