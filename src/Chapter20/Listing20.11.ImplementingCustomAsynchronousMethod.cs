namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_11;

#region INCLUDE
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

public class Program
{
    public static Task<Process> RunProcessAsync(
        string fileName,
        string arguments = "",
        CancellationToken cancellationToken = default)
    {
        TaskCompletionSource<Process> taskCS =
                      new();

        Process process = new()
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

        #region HIGHLIGHT
        cancellationToken
            .ThrowIfCancellationRequested();
        #endregion HIGHLIGHT

        process.Start();

        #region HIGHLIGHT
        cancellationToken.Register(() =>
        {
            Process.GetProcessById(process.Id).Kill();
        });
        #endregion HIGHLIGHT

        return taskCS.Task;
    }
    // ...
}
#endregion INCLUDE






