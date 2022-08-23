using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_06.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void MainTest()
        {
            const string expected = @".\Microsoft.TestPlatform.AdapterUtilities.dll (2/15/2022 6:54:30 PM)
.\Microsoft.TestPlatform.CommunicationUtilities.dll (5/10/2022 7:12:56 AM)
.\Microsoft.TestPlatform.CoreUtilities.dll (5/10/2022 7:06:34 AM)
.\Microsoft.TestPlatform.CrossPlatEngine.dll (5/10/2022 7:13:24 AM)
.\Microsoft.TestPlatform.PlatformAbstractions.dll (5/10/2022 7:12:52 AM)
.\Microsoft.TestPlatform.Utilities.dll (5/10/2022 7:12:52 AM)
.\Microsoft.VisualStudio.CodeCoverage.Shim.dll (3/31/2022 4:27:56 AM)
.\Microsoft.VisualStudio.TestPlatform.Common.dll (5/10/2022 7:13:24 AM)
.\Microsoft.VisualStudio.TestPlatform.MSTest.TestAdapter.dll (4/26/2022 6:53:30 AM)
.\Microsoft.VisualStudio.TestPlatform.MSTestAdapter.PlatformServices.dll (4/26/2022 6:50:56 AM)
.\Microsoft.VisualStudio.TestPlatform.MSTestAdapter.PlatformServices.Interface.dll (4/26/2022 6:49:26 AM)
.\Microsoft.VisualStudio.TestPlatform.ObjectModel.dll (5/10/2022 7:07:02 AM)
.\Microsoft.VisualStudio.TestPlatform.TestFramework.dll (4/26/2022 6:51:04 AM)
.\Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.dll (4/26/2022 6:48:06 AM)
.\Newtonsoft.Json.dll (6/13/2016 4:06:14 PM)
.\NuGet.Frameworks.dll (6/1/2021 1:46:32 PM)
.\System.CodeDom.dll (5/15/2018 6:29:52 AM)
.\testhost.dll (5/10/2022 7:12:56 AM)
.\testhost.exe (5/10/2022 6:48:18 AM)";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}