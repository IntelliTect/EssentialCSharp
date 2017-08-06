namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_17
{
    using System;
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
                Console.WriteLine($@"Send notification invoked...(Thread ID: {
                    Thread.CurrentThread.ManagedThreadId})");
                d(state);
            }
            catch (Exception ex)
            {
               Exception = ex;
#if !WithOutIsingResetEvent
                ResetEvent.Set();
#endif
            }
        }

        public override void Post(SendOrPostCallback d, object state)
        {
            try
            {
                Console.WriteLine($@"Post notification invoked...(Thread ID: {
                    Thread.CurrentThread.ManagedThreadId})");
                d(state);
            }
            catch (Exception ex)
            {
                Exception = ex;
#if !WithOutIsingResetEvent
                ResetEvent.Set();
#endif
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

#if WithOutIsingResetEvent
                Task.Delay(1000);  // 
#else
                synchronizationContext.ResetEvent.Wait();
#endif

                if(synchronizationContext.Exception != null)
                {
                    Console.WriteLine($@"Throwing expected exception....(Thread ID: {
                    Thread.CurrentThread.ManagedThreadId})");
#if NET40
                    using System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(
                        synchronizationContext.Exception).Throw();
#else
                throw synchronizationContext.Exception;
#endif
                }
            }
            catch(Exception exception)
            {
                Console.WriteLine($@"{exception} thrown as expected.(Thread ID: {
                    Thread.CurrentThread.ManagedThreadId})");
            }
        }

        static async void OnEvent(object sender, EventArgs eventArgs)
        {
            Console.WriteLine($@"Invoking Task.Run...(Thread ID: {
                    Thread.CurrentThread.ManagedThreadId})");
            await Task.Run(()=>
            {
                Console.WriteLine($@"Running task... (Thread ID: {
                    Thread.CurrentThread.ManagedThreadId})");
                throw new Exception(ExpectedExceptionMessage);
            });
        }
    }
}
