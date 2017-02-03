using AddisonWesley.Michaelis.EssentialCSharp3.Chapter5.Listing5_01to06;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntelliTechture;

namespace AddisonWesley.Michaelis.EssentialCSharp3.Chapter5.Listing5_01to06.Test
{
    /// <summary>
    ///This is a test class for ProgramTest and is intended
    ///to contain all ProgramTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProgramTest
    {
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext{ get; set; }

        /// <summary>
        ///A test for Main
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Listing5_01-06.exe")]
        public void Listing5_01to06()
        {
            using( ConsoleTester consoleTester = ConsoleTester.GetConsoleTester(
                "<<Inigo Montoya: Enough to survive on\r\n" ))
            {
                Program_Accessor.Main();
            }
        }
    }
}
