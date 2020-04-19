using AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_03;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_03
{

    [TestClass]
    public class ProgramTests : BaseProgramTests
    {
        [ClassInitialize]
        static public void ClassInitialize(TestContext _)
        {
            //ProgramWrapper = new ProgramWrapper(
            //    (string[] args)=> Program.Main(args),
            //    (findText, urls, progress) => Program.FindTextInWebUriAsync(findText, urls.First(), progress));
        }

        protected override void AssertMainException(string messagePrefix, Exception exception)
        {
            Assert.AreEqual<Type>(typeof(AggregateException), exception.GetType());  // Testing type first (even though the cast will also verify)

            AssertAggregateExceptionType(messagePrefix, (AggregateException)exception);
        }

        protected override string DefaultUrl => Program.DefaultUrl;
    }
}
