using AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_01;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_02
{

    [TestClass]
    public class ProgramTests : BaseProgramTests
    {
        [ClassInitialize]
        static public void ClassInitialize(TestContext _)
        {
            ProgramWrapper = new ProgramWrapper(
                (string[] args)=> Program.Main(args),
                (findText, urls, progress) => Program.FindTextInWebUriAsync(findText, urls.First(), progress));
        }

        protected override void AssertMainException(string messagePrefix, Exception exception)
        {
            Assert.AreEqual<Type>(typeof(AggregateException), exception.GetType());  // Testing type first (even though the cast will also verify)

            AssertAggregateExceptionType(messagePrefix, (AggregateException)exception);
        }
    }
}
