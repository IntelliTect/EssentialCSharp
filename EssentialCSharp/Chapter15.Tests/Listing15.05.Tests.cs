using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_05.Tests
{

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void InvokingDelegateWithoutCheckingForNull()
        {
            string expected = @"1. delegateInvocations=0
2. Contextual keyword count=27
3. delegateInvocations=27
4. Contextual keyword count=27
5. delegateInvocations=54
6. delegateInvocations=81
7. selectionCache count=27
8. delegateInvocations=81";

            IntelliTect.ConsoleView.Tester.Test(expected,
            () =>
            {
                Program.Main();
            });
        }
    }
}