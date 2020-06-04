using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_14
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main()
        {
            string expected = @"Invoking ((IExecuteProcessActivity)activity).Run()...
IWorkflowActivity.Start()...
ExecuteProcessActivity.RedirectStandardInOut()...
ExecuteProcessActivity.IExecuteProcessActivity.ExecuteProcess()...
IExecuteProcessActivity.RestoreStandardInOut()...
IWorkflowActivity.Stop()...

Invoking activity.Run()...
Executing non-polymorphic Run() with process 'dotnet'.";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected,
                Program.Main);
        }
    }
}
