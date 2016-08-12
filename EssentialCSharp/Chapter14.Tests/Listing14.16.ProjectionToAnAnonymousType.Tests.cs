using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_16.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ProjectionToAnAnonymousType()
        {
            string expected =
@"{ FileName = Chapter14.Tests.csproj, Size = \d+ }
{ FileName = Chapter14.Tests.xproj, Size = \d+ }
{ FileName = Chapter14.Tests.xproj.user, Size = \d+ }
{ FileName = Listing14.04.Tests.cs, Size = \d+ }
{ FileName = Listing14.15.ProjectionWithSystem.Linq.Enumerable.Select.Tests.cs, Size = \d+ }
{ FileName = Listing14.16.ProjectionToAnAnonymousType.Tests.cs, Size = \d+ }
{ FileName = Listing14.17.ExecutingLinqQueriesInParallel.Tests.cs, Size = \d+ }
{ FileName = Listing14.28.MoreSystem.Linq.EnumerableMethodCalls.Tests.cs, Size = \d+ }
{ FileName = project.json, Size = \d+ }
{ FileName = project.lock.json, Size = \d+ }";

            Intellitect.ConsoleView.Tester.AreLike(expected,
            () =>
            {
                Program.ChapterMain();
            });
        }
    }
}
