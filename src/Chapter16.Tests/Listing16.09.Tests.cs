using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_09.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void MainTest()
        {
            const string expected = @".\Chapter16.runtimeconfig.json(154)
.\Chapter16.Tests.runtimeconfig.json(154)
.\Chapter16.runtimeconfig.dev.json(184)
.\Chapter16.Tests.runtimeconfig.dev.json(184)
.\CoverletSourceRootsMapping(268)
.\Chapter16.deps.json(844)
.\Microsoft.VisualStudio.CodeCoverage.Shim.dll(17328)
.\Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.dll(18336)
.\Chapter16.pdb(19004)
.\Microsoft.VisualStudio.TestPlatform.MSTestAdapter.PlatformServices.Interface.dll(19360)
.\Chapter16.Tests.pdb(20268)
.\Chapter16.Tests.dll(24576)
.\IntelliTect.TestTools.Console.dll(24576)
.\Microsoft.TestPlatform.AdapterUtilities.dll(29064)
.\testhost.dll(34704)
.\Microsoft.TestPlatform.PlatformAbstractions.dll(35216)
.\Chapter16.dll(36864)
.\Microsoft.TestPlatform.Utilities.dll(52112)
.\Microsoft.VisualStudio.TestPlatform.MSTestAdapter.PlatformServices.dll(63376)
.\Microsoft.TestPlatform.CoreUtilities.dll(66976)
.\Microsoft.VisualStudio.TestPlatform.TestFramework.dll(74128)
.\Chapter16.Tests.deps.json(77335)
.\Microsoft.TestPlatform.CommunicationUtilities.dll(103312)
.\NuGet.Frameworks.dll(108920)
.\testhost.exe(143776)
.\Microsoft.VisualStudio.TestPlatform.MSTest.TestAdapter.dll(159144)
.\Chapter16.exe(174592)
.\Microsoft.VisualStudio.TestPlatform.ObjectModel.dll(177056)
.\Microsoft.VisualStudio.TestPlatform.Common.dll(181136)
.\System.CodeDom.dll(187016)
.\Microsoft.TestPlatform.CrossPlatEngine.dll(233872)
.\Newtonsoft.Json.dll(468480)";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
        }
    }
}