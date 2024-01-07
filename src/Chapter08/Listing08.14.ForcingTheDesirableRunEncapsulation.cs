// TODO: Update listing in Manuscript
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_14;

#region INCLUDE
public interface IWorkflowActivity
{
    // 私有，因此非虚
    private static void Start() =>
        Console.WriteLine(
            "IWorkflowActivity.Start()...");

    // 密封以防止重写
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

    // 私有，因此非虚
    private static void Stop() =>
        Console.WriteLine(
            "IWorkflowActivity.Stop()...");
}

public interface IExecuteProcessActivity : IWorkflowActivity
{
    protected void RedirectStandardInOut() =>
        Console.WriteLine(
            "IExecuteProcessActivity.RedirectStandardInOut()...");

    // 密封的不允许重写
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

public class ExecuteProcessActivity : IExecuteProcessActivity
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

    public static void Run()
    {
        ExecuteProcessActivity activity = new("dotnet");
        // 受保护成员不可由实现类调用，
        // 即使该成员是在类中实现的。
        // ((IWorkflowActivity)this).InternalRun();
        //  activity.RedirectStandardInOut();
        //  activity.ExecuteProcess();
        Console.WriteLine(
            @$"正在用进程'{activity.ExecutableName}'执行非多态性的Run()。");
    }
}

public class Program
{
    public static void Main()
    {
        ExecuteProcessActivity activity = new("dotnet");

        Console.WriteLine(
            "正在调用((IExecuteProcessActivity)activity).Run()...");
        // 输出:
        // 正在调用((IExecuteProcessActivity)activity).Run()...
        // IWorkflowActivity.Start()...
        // ExecuteProcessActivity.RedirectStandardInOut()...
        // ExecuteProcessActivity.IExecuteProcessActivity.
        // ExecuteProcess()...
        // IExecuteProcessActivity.RestoreStandardInOut()...
        // IWorkflowActivity.Stop()..
        ((IExecuteProcessActivity)activity).Run();

        // 输出:
        // 正在调用activity.Run()...
        // 正在用进程'dotnet'执行非多态性的Run()。
        Console.WriteLine();
        Console.WriteLine(
            "正在调用activity.Run()...");
        ExecuteProcessActivity.Run();
    }
}
#endregion INCLUDE
