namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_19
{
    using System.Diagnostics;
    using System.Threading;
    using System.Threading.Tasks;

    class Program
    {
        static public Task<Process> RunProcessAsync(
            string fileName,
            string arguments = null,
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
                    Arguments = arguments
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
}






