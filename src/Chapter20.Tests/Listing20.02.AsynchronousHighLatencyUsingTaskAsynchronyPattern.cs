using AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_13;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_02
{

    [TestClass]
    public class ProgramTests : BaseProgramTests
    {
        [ClassInitialize]
        static public void ClassInitialize(TestContext _)
        {
            ProgramWrapper = new ProgramWrapper(
                Program.Main,
                (findText, urls, progress) => Program.FindTextInWebUriAsync(findText, urls.First(), progress));
        }

        protected override void AssertMainException(string messagePrefix, Exception exception)
        {
            Assert.AreEqual<Type>(typeof(AggregateException), exception.GetType());  // Testing type first (even though the cast will also verify)

            AssertAggregateExceptionType(messagePrefix, (AggregateException)exception);
        }
    }
}
