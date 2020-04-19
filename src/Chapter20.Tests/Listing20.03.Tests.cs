using AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_03.Tests
{

    [TestClass]
    public class ProgramTests : BaseProgramTests
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext _)
        {
            ProgramWrapper = new ProgramWrapper(
                (args) =>
                    Task.Run(() => Program.Main(args)));
        }

        override protected void AssertMainException(string messagePrefix, Exception exception)
        {
            Assert.IsTrue(
                    // Handle exceptions rethrown in Listing 19.14
                    IntelliTect.TestTools.Console.StringExtensions.IsLike(exception.Message, "Rethrowing...*") &&
                    IntelliTect.TestTools.Console.StringExtensions.IsLike(exception?.InnerException?.Message, messagePrefix)
                );
        }

        protected override void AssertFindTextInWebUriException(string messagePrefix, Exception exception)
        {
            AssertAggregateExceptionType(messagePrefix, (AggregateException)exception);
        }

        protected override string DefaultUrl { get; } = Program.DefaultUrl;
    }
}
