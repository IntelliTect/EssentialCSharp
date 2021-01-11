using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_05.Tests
{

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void InvokingDelegateWithoutCheckingForNull()
        {
            string expected = @"1. delegateInvocations=0
2. Contextual keyword count=29
3. delegateInvocations=29
4. Contextual keyword count=29
5. delegateInvocations=58
6. delegateInvocations=87
7. selectionCache count=29
8. delegateInvocations=87";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            () =>
            {
                Program.Main();
            });
        }
    }
}