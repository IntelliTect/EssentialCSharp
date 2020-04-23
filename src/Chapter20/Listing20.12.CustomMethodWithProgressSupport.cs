namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_12
{
    using System;
    using System.Diagnostics;
    using System.Threading;
    using System.Threading.Tasks;

    class Program
    {
        static public Task<Process> RunProcessAsync(
            string fileName,
            string arguments = "",
            CancellationToken cancellationToken =
                default(CancellationToken),
                IProgress<ProcessProgressEventArgs>? progress = null,
                object? objectState = null)
        {
            TaskCompletionSource<Process> taskCS =
                          new TaskCompletionSource<Process>();

            Process process = new Process()
            {
                StartInfo = new ProcessStartInfo(fileName)
                {
                    UseShellExecute = false,
                    Arguments = arguments,
                    RedirectStandardOutput =
                       progress != null
                },
                EnableRaisingEvents = true
            };

            process.Exited += (sender, localEventArgs) =>
            {
                taskCS.SetResult(process);
            };

            cancellationToken
                .ThrowIfCancellationRequested();

            process.Start();

            cancellationToken.Register(() =>
            {
                Process.GetProcessById(process.Id).Kill();
            });

            return taskCS.Task;
        }

        // ...
    }

    class ProcessProgressEventArgs
    {
        // ...
    }
}
