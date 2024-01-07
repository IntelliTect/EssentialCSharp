// TODO: Update listing in Manuscript
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_14;

#region INCLUDE
public interface IWorkflowActivity
{
    // ˽�У���˷���
    private static void Start() =>
        Console.WriteLine(
            "IWorkflowActivity.Start()...");

    // �ܷ��Է�ֹ��д
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

    // ˽�У���˷���
    private static void Stop() =>
        Console.WriteLine(
            "IWorkflowActivity.Stop()...");
}

public interface IExecuteProcessActivity : IWorkflowActivity
{
    protected void RedirectStandardInOut() =>
        Console.WriteLine(
            "IExecuteProcessActivity.RedirectStandardInOut()...");

    // �ܷ�Ĳ�������д
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
        // �ܱ�����Ա������ʵ������ã�
        // ��ʹ�ó�Ա��������ʵ�ֵġ�
        // ((IWorkflowActivity)this).InternalRun();
        //  activity.RedirectStandardInOut();
        //  activity.ExecuteProcess();
        Console.WriteLine(
            @$"�����ý���'{activity.ExecutableName}'ִ�зǶ�̬�Ե�Run()��");
    }
}

public class Program
{
    public static void Main()
    {
        ExecuteProcessActivity activity = new("dotnet");

        Console.WriteLine(
            "���ڵ���((IExecuteProcessActivity)activity).Run()...");
        // ���:
        // ���ڵ���((IExecuteProcessActivity)activity).Run()...
        // IWorkflowActivity.Start()...
        // ExecuteProcessActivity.RedirectStandardInOut()...
        // ExecuteProcessActivity.IExecuteProcessActivity.
        // ExecuteProcess()...
        // IExecuteProcessActivity.RestoreStandardInOut()...
        // IWorkflowActivity.Stop()..
        ((IExecuteProcessActivity)activity).Run();

        // ���:
        // ���ڵ���activity.Run()...
        // �����ý���'dotnet'ִ�зǶ�̬�Ե�Run()��
        Console.WriteLine();
        Console.WriteLine(
            "���ڵ���activity.Run()...");
        ExecuteProcessActivity.Run();
    }
}
#endregion INCLUDE
