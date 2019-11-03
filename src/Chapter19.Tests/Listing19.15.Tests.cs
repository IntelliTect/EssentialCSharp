using AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_13to14.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;
using System.Threading.Tasks;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_15.Tests
{

    [TestClass]
    public class ProgramTests : BaseProgramTests<Task<int>>
    {
        [ClassInitialize]
        static public void ClassInitialize(TestContext textContext)
        {
            ProgramWrapper = new ProgramWrapper<Task<int>>(Program.Main, Program.FindTextInWebUriAsync);
        }

        override protected void AssertExceptionTypeAndMessage(string messagePrefix, Exception exception)
        {
            Assert.IsTrue(
                    // Handle exceptions rethrown in Listing 19.14
                    IntelliTect.TestTools.Console.StringExtensions.IsLike(exception.Message, "Rethrowing...*") &&
                    IntelliTect.TestTools.Console.StringExtensions.IsLike(exception?.InnerException?.Message, messagePrefix)
                );
        }
    }
}
