using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_14
{
    public interface IWorkflowActivity
    {
        // Private and, therefore, not virtual
        private void Start() =>
            Console.WriteLine(
                "IWorkflowActivity.Start()...");

        // Sealed to prevent overriding.
        sealed void Run()
        {
            try
            {
                Start();
                InternalRun();
            }
            finally
            {
                Stop();
            }
        }

        protected void InternalRun();

        // Private and, therefore, not virtual
        private void Stop() =>
            Console.WriteLine(
                "IWorkflowActivity.Stop()...");
    }

    public interface IExecuteProcessActivity : IWorkflowActivity
    {
        protected void RedirectStandardInOut() =>
            Console.WriteLine(
                "IExecuteProcessActivity.RedirectStandardInOut()...");

        // Sealed not allowed when overriding.
        /* sealed */
        void IWorkflowActivity.InternalRun()
        {
            RedirectStandardInOut();
            ExecuteProcess();
            RestoreStandardInOut();
        }
        protected void ExecuteProcess();
        protected void RestoreStandardInOut() =>
            Console.WriteLine(
                "IExecuteProcessActivity.RestoreStandardInOut()...");
    }

    class ExecuteProcessActivity : IExecuteProcessActivity
    {
        public ExecuteProcessActivity(string executablePath) =>
            ExecutableName = executablePath
                ?? throw new ArgumentNullException(nameof(executablePath));

        public string ExecutableName { get; }

        void IExecuteProcessActivity.RedirectStandardInOut() =>
            Console.WriteLine(
                "ExecuteProcessActivity.RedirectStandardInOut()...");

        void IExecuteProcessActivity.ExecuteProcess() =>
            Console.WriteLine(
                $"ExecuteProcessActivity.IExecuteProcessActivity.ExecuteProcess()...");

        public void Run()
        {
            ExecuteProcessActivity activity
                = new ExecuteProcessActivity("dotnet");
            // Protected members cannot be invoked
            // by the implementing class even when
            //  implemented in the class.
            // ((IWorkflowActivity)this).InternalRun();
            //  activity.RedirectStandardInOut();
            //  activity.ExecuteProcss();
            Console.WriteLine(
                @$"Executing non-polymorphic Run() with process '{
                    activity.ExecutableName}'.");
        }
    }

    public class Program
    {
        static public void Main()
        {
            ExecuteProcessActivity activity
                = new ExecuteProcessActivity("dotnet");

            Console.WriteLine(
                "Invoking ((IExecuteProcessActivity)activity).Run()...");
            // Output:
            // Invoking ((IExecuteProcessActivity)activity).Run()...
            // IWorkflowActivity.Start()...
            // ExecuteProcessActivity.RedirectStandardInOut()...
            // ExecuteProcessActivity.IExecuteProcessActivity.ExecuteProcess()...
            // IExecuteProcessActivity.RestoreStandardInOut()...
            // IWorkflowActivity.Stop()..
            ((IExecuteProcessActivity)activity).Run();

            // Output:
            // Invoking activity.Run()...
            // Executing non-polymorphic Run() with process 'dotnet'.
            Console.WriteLine();
            Console.WriteLine(
                "Invoking activity.Run()...");
            activity.Run();
        }
    }
}
