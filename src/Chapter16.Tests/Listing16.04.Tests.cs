using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_04.Tests
{

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void InvokingDelegateWithoutCheckingForNull()
        {
            string expected = @"Query created.
 add* alias* ascending* async* await* by* descending* dynamic* equals* from* get* global* group* into* join* let* nameof* nonnull* on* orderby* partial* remove* select* set* value* var* when* where* yield*";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            () =>
            {
                Program.Main();
            });
        }
    }
}