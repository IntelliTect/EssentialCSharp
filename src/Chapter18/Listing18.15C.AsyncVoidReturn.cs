namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_15C
{
    using System;
    using System.Diagnostics;
    using System.Threading;
    using System.Threading.Tasks;

    public class AsyncSynchronizationContext : SynchronizationContext
    {
        public Exception Exception { get; set; }
        public ManualResetEventSlim ResetEvent { get;} = new ManualResetEventSlim();

        public override void Send(SendOrPostCallback d, object state)
        {
            try
            {
                Console.WriteLine("Inside Send");
                d(state);
            }
            catch (Exception ex)
            {
               Exception = ex;
            }
            finally
            {
                ResetEvent.Set();
            }
        }

        public override void Post(SendOrPostCallback d, object state)
        {
            try
            {
                Console.WriteLine("Inside Post");
                d(state);
            }
            catch (Exception ex)
            {
               Exception = ex;
            }
            finally
            {
                ResetEvent.Set();
            }
            
        }
    }

    public class Program
    {
        static bool EventTriggered { get; set; }

        public const string ExpectedExceptionMessage = "Expected Exception";
        public static void Main()
        {

            AsyncSynchronizationContext synchronizationContext = new AsyncSynchronizationContext();
            SynchronizationContext.SetSynchronizationContext(synchronizationContext);
            
            try
            {
                
                OnEvent(null, null);

                synchronizationContext.ResetEvent.Wait();
                if(synchronizationContext.Exception != null)
                {
                    Console.WriteLine("Throwing expected exception....");
                    throw synchronizationContext.Exception;
                }

            }
            finally
            {
                //if(!EventTriggered) { throw new Exception("The event never triggered.");};
                
                //if(synchronizationContext.Exception == null) { throw new Exception("The unhandled exception was not caught."); };
                //Console.WriteLine($"{synchronizationContext.Exception} thrown as expected.");
            }
        }

        static async void OnEvent(object sender, EventArgs eventArgs)
        {
            EventTriggered = true;
            await Task.Run(()=>{;});
            throw new Exception(ExpectedExceptionMessage);
        }
    }
}
