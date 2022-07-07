namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_12
{
    #region INCLUDE
    using System;
    using System.Diagnostics;
    using System.Threading;
    using System.Threading.Tasks;

    public class Program
    {
        static public Task<Process> RunProcessAsync(
            string fileName,
            string arguments = "",
        #region HIGHLIGHT
            IProgress<ProcessProgressEventArgs>? progress = 
                null, object? objectState = null,
        #endregion HIGHLIGHT
            CancellationToken cancellationToken =
                default(CancellationToken))
        {
            TaskCompletionSource<Process> taskCS =
                          new TaskCompletionSource<Process>();

            Process process = new Process()
            {
                StartInfo = new ProcessStartInfo(fileName)
                {
                    UseShellExecute = false,
                    Arguments = arguments,
                    #region HIGHLIGHT
                    RedirectStandardOutput =
                       progress != null
                    #endregion HIGHLIGHT
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
    #endregion INCLUDE
}
