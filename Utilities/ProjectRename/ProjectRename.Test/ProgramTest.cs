using ProjectRename;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntelliTechture;
using System.IO;
using System;
using SystemEx.IO;
namespace ProjectRename.Test
{
    
    
    /// <summary>
    ///This is a test class for ProgramTest and is intended
    ///to contain all ProgramTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProgramTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        [TestMethod]
        [DeploymentItem("MockProject", "MockProject")]
        public void RootDirectoryDoesNotExist()
        {
            string root = @".\Blah\";
            string chapter = "5";
            string fromListing = "15-29";
            string toListing = "30-31";
            using (ConsoleTester tester = ConsoleTester.GetConsoleTester(
                string.Format("<<{0}\r\n", Program.HelpText) +
                string.Format(@"<>The chapter folder, ""{0}\Blah\Chapter05\Listing5_30-31"", could not be found." + Environment.NewLine,
                    Environment.CurrentDirectory)))
            {
                Assert.AreEqual<int>(-1, Program.Main(root, chapter, fromListing, toListing));
            }
        }

        [TestMethod]
        [DeploymentItem("MockProject", "MockProject")]
        public void RootDirectoryWithoutTrailingSlash()
        {
            string root = @".\Blah\";
            string chapter = "5";
            string fromListing = "15-29";
            string toListing = "30-31";
            using (ConsoleTester tester = ConsoleTester.GetConsoleTester(
                string.Format("<<{0}\r\n", Program.HelpText) +
                string.Format(@"<>The chapter folder, ""{0}\Blah\Chapter05\Listing5_30-31"", could not be found." + Environment.NewLine,
                    Environment.CurrentDirectory)))
            {
                Assert.AreEqual<int>(-1, Program.Main(root, chapter, fromListing, toListing));
            }
        }

        [TestMethod]
        [DeploymentItem("MockProject", "MockProject")]
        public void ChapterDirectoryDoesNotExist()
        {
            string root = @".\MockProject\";
            string chapter = "99";
            string fromListing = "15-29";
            string toListing = "30-31";
            using (ConsoleTester tester = ConsoleTester.GetConsoleTester(
                string.Format("<<{0}\r\n", Program.HelpText) +
                string.Format(@"<>The chapter folder, ""{0}\MockProject\Chapter99\Listing99_30-31"", could not be found." + Environment.NewLine,
                    Environment.CurrentDirectory)))
            {
                Assert.AreEqual<int>(-1, Program.Main(root, chapter, fromListing, toListing));
            }
        }

        [TestMethod]
        [DeploymentItem(@"..\..\SourceCode\Chapter05\", @"MockProject\Chapter05")]
        [DeploymentItem(@"..\..\SourceCode\Chapter05.Test\", @"MockProject\Chapter05.Test")]
        public void MainTest1()
        {
            string root = @".\MockProject\";
            string chapter = "5";
            string fromListing = "15-29";
            string toListing = "98-99";
            
            string fromName = string.Format("Listing{0}_{1}", chapter, fromListing);
            string toName = string.Format("Listing{0}_{1}", chapter, toListing);
            string chapterFolder = "Chapter" + chapter.PadLeft(2, '0');
            string fromProjectName = string.Format("{0}.Listing{1}_{2}", chapterFolder, chapter, fromListing);
            string toProjectName = string.Format("{0}.Listing{1}_{2}", chapterFolder, chapter, toListing);

            Program.Main(root, chapter, fromListing, toListing);

            DirectoryInfo fromProjectDirectory = new DirectoryInfo(PathEx.Combine(root, chapterFolder, fromName));
            Assert.IsTrue(fromProjectDirectory.Exists, "From project directory does not exists.  Problem with the test.");

            DirectoryInfo toProjectDirectory = new DirectoryInfo(PathEx.Combine(root, chapterFolder, toName));
            Assert.IsTrue(fromProjectDirectory.Exists, "to directory was not even created");

            foreach (FileInfo file in toProjectDirectory.GetFiles("*", SearchOption.AllDirectories))
            {
                if (file.Directory.Parent.Name.ToLower() != "bin" && file.Directory.Parent.Name.ToLower() != "obj")
                {
                    TestContext.WriteLine(file.Name);
                    Assert.IsFalse(file.Name.Contains(fromName));
                    using (StreamReader reader = new StreamReader(file.FullName))
                    {
                        string content = reader.ReadToEnd();
                        Assert.IsFalse(content.Contains(fromName));
                        Assert.IsFalse(content.Contains(fromName.Replace("-", "to")));
                    }
                }
            }


        }

        [TestMethod]
        [DeploymentItem(@"..\..\SourceCode\Chapter05\", @"MockProject\Chapter05")]
        [DeploymentItem(@"..\..\SourceCode\Chapter05.Test\", @"MockProject\Chapter05.Test")]
        public void MainTest2()
        {
            string root = @".\MockProject\";
            string chapter = "5";
            string fromListing = "15-29";
            string toListing = "98-99";
            
            string fromName = string.Format("Listing{0}_{1}", chapter, fromListing);
            string toName = string.Format("Listing{0}_{1}", chapter, toListing);
            string chapterFolder = "Chapter" + chapter.PadLeft(2, '0');
            string fromProjectName = string.Format("{0}.Listing{1}_{2}", chapterFolder, chapter, fromListing);
            string toProjectName = string.Format("{0}.Listing{1}_{2}", chapterFolder, chapter, toListing);

            ConsoleTester tester = ConsoleTester.GetConsoleTester();
            tester.Execute(".\\ProjectRename.exe", string.Format("{0} {1} {2} {3}", root, chapter, fromListing, toListing));

            DirectoryInfo fromProjectDirectory = new DirectoryInfo(PathEx.Combine(root, chapterFolder, fromName));
            Assert.IsTrue(fromProjectDirectory.Exists, "From project directory does not exists.  Problem with the test.");

            DirectoryInfo toProjectDirectory = new DirectoryInfo(PathEx.Combine(root, chapterFolder, toName));
            Assert.IsTrue(fromProjectDirectory.Exists, "to directory was not even created");

            foreach (FileInfo file in toProjectDirectory.GetFiles("*", SearchOption.AllDirectories))
            {
                if (file.Directory.Parent.Name.ToLower() != "bin" && file.Directory.Parent.Name.ToLower() != "obj")
                {
                    TestContext.WriteLine(file.Name);
                    Assert.IsFalse(file.Name.Contains(fromName));
                    using (StreamReader reader = new StreamReader(file.FullName))
                    {
                        string content = reader.ReadToEnd();
                        Assert.IsFalse(content.Contains(fromName));
                        Assert.IsFalse(content.Contains(fromName.Replace("-", "to")));
                    }
                }
            }


        }
    }
}
