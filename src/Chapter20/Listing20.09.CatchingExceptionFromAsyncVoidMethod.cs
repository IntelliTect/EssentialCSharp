// Justification: Catching general exception types to demonstrate control flow.
#pragma warning disable CA1031 // Do not catch general exception types

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_09
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class AsyncSynchronizationContext : SynchronizationContext
    {
        public Exception? Exception { get; set; }
        public ManualResetEventSlim ResetEvent { get; } = 
            new ManualResetEventSlim();

        public override void Send(SendOrPostCallback callback, object? state)
        {
            try
            {
                Console.WriteLine($@"Send notification invoked...(Thread ID: {
                    Thread.CurrentThread.ManagedThreadId})");
                callback(state);
            }
            catch (Exception exception)
            {
                Exception = exception;
#if !WithOutUsingResetEvent
                ResetEvent.Set();
#endif
            }
        }

        public override void Post(SendOrPostCallback callback, object? state)
        {
            try
            {
                Console.WriteLine($@"Post notification invoked...(Thread ID: {
                    Thread.CurrentThread.ManagedThreadId})");
                callback(state);
            }
            catch (Exception exception)
            {
                Exception = exception;
#if !WithOutUsingResetEvent
                ResetEvent.Set();
#endif
            }
        }
    }

    public static class Program
    {
        public static bool EventTriggered { get; set; }

        public const string ExpectedExceptionMessage = "Expected Exception";

        public static void Main()
        {
            SynchronizationContext? originalSynchronizationContext =
                SynchronizationContext.Current;
            try
            {
                AsyncSynchronizationContext synchronizationContext = 
                    new AsyncSynchronizationContext();
                SynchronizationContext.SetSynchronizationContext(
                    synchronizationContext);

                OnEvent(typeof(Program), new EventArgs());

#if WithOutUsingResetEvent
                Task.Delay(1000).Wait();  // 
#else
                synchronizationContext.ResetEvent.Wait();
#endif

                if (synchronizationContext.Exception != null)
                {
                    Console.WriteLine($@"Throwing expected exception....(Thread ID: {
                    Thread.CurrentThread.ManagedThreadId})");
                    System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(
                        synchronizationContext.Exception).Throw();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine($@"{exception} thrown as expected.(Thread ID: {
                    Thread.CurrentThread.ManagedThreadId})");
            }
            finally
            {
                SynchronizationContext.SetSynchronizationContext(
                    originalSynchronizationContext);
            }
        }

        static async void OnEvent(object sender, EventArgs eventArgs)
        {
            Console.WriteLine($@"Invoking Task.Run...(Thread ID: {
                    Thread.CurrentThread.ManagedThreadId})");
            await Task.Run(() =>
            {
                EventTriggered = true;
                Console.WriteLine($@"Running task... (Thread ID: {
                    Thread.CurrentThread.ManagedThreadId})");
                throw new Exception(ExpectedExceptionMessage);
            });
        }
    }
}
