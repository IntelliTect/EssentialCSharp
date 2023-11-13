namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_12;

#region INCLUDE
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

public class Program
{
    public static Task<Process> RunProcessAsync(
        string fileName,
        string arguments = "",
    #region HIGHLIGHT
        IProgress<ProcessProgressEventArgs>? progress = 
            null, object? objectState = null,
    #endregion HIGHLIGHT
        CancellationToken cancellationToken =
            default(CancellationToken))
    {
        TaskCompletionSource<Process> taskCS = new();

        Process process = new()
        {
            StartInfo = new ProcessStartInfo(fileName)
            {
                UseShellExecute = false,
                Arguments = arguments,
                #region HIGHLIGHT
                RedirectStandardOutput =
                   progress is not null
                #endregion HIGHLIGHT
            },
            EnableRaisingEvents = true
        };

        process.Exited += (sender, localEventArgs) =>
        {
            taskCS.SetResult(process);
        };

        #region HIGHLIGHT
        if (progress is not null)
        {
            process.OutputDataReceived +=
                (sender, localEventArgs) =>
            {
                progress.Report(
                    new ProcessProgressEventArgs(
                        localEventArgs.Data,
                        objectState));
            };
        }
        #endregion HIGHLIGHT

        cancellationToken
            .ThrowIfCancellationRequested();

        process.Start();

        #region HIGHLIGHT
        if (progress !=null)
        {
            process.BeginOutputReadLine();
        }
        #endregion HIGHLIGHT

        cancellationToken.Register(() =>
        {
            Process.GetProcessById(process.Id).Kill();
        });

        return taskCS.Task;
    }

    // ...
}

public class ProcessProgressEventArgs
{
    #region EXCLUDE
    public ProcessProgressEventArgs(string? _,object? __){}
    #endregion EXCLUDE
}
#endregion INCLUDE
