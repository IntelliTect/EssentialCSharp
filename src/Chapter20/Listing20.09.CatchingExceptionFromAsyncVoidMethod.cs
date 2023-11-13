namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_09;

#region INCLUDE
using System;
using System.Threading;
using System.Threading.Tasks;

public class AsyncSynchronizationContext : SynchronizationContext
{
    public Exception? Exception { get; set; }
    public ManualResetEventSlim ResetEvent { get; } = new();

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
        }
        finally
        {
            ResetEvent.Set();
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
        }
        finally
        {
            ResetEvent.Set();
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
            AsyncSynchronizationContext synchronizationContext = new();
            SynchronizationContext.SetSynchronizationContext(
                synchronizationContext);

            OnEvent(typeof(Program), EventArgs.Empty);

            synchronizationContext.ResetEvent.Wait();

            if (synchronizationContext.Exception is not null)
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

    private static async void OnEvent(object sender, EventArgs eventArgs)
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
#endregion INCLUDE
