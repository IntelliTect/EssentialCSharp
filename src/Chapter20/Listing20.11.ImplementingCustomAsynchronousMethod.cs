namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_11
{
    using System.Diagnostics;
    using System.Threading;
    using System.Threading.Tasks;

    class Program
    {
        static public Task<Process> RunProcessAsync(
            string fileName,
            string arguments = "",
            CancellationToken cancellationToken = default)
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






