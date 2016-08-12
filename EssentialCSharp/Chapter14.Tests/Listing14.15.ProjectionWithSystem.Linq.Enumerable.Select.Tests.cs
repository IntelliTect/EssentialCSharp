using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_15.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Listing14_15_Test()
        {
            string expected =
$@"{ Directory.GetCurrentDirectory() }\Chapter14.Tests.csproj
{ Directory.GetCurrentDirectory() }\Chapter14.Tests.xproj
{ Directory.GetCurrentDirectory() }\Chapter14.Tests.xproj.user
{ Directory.GetCurrentDirectory() }\Listing14.04.Tests.cs
{ Directory.GetCurrentDirectory() }\Listing14.15.ProjectionWithSystem.Linq.Enumerable.Select.Tests.cs
{ Directory.GetCurrentDirectory() }\Listing14.16.ProjectionToAnAnonymousType.Tests.cs
{ Directory.GetCurrentDirectory() }\Listing14.17.ExecutingLinqQueriesInParallel.Tests.cs
{ Directory.GetCurrentDirectory() }\Listing14.28.MoreSystem.Linq.EnumerableMethodCalls.Tests.cs
{ Directory.GetCurrentDirectory() }\project.json
{ Directory.GetCurrentDirectory() }\project.lock.json";

            Intellitect.ConsoleView.Tester.Test(expected,
            () =>
            {
                Program.ChapterMain();
            });
        }
    }
}