using AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_03
{

    [TestClass]
    public class ProgramTests : BaseProgramTests
    {
        [ClassInitialize]
        static public void ClassInitialize(TestContext _)
        {
            ProgramWrapper = new ProgramWrapper(
                (string[] args)=> Program.Main(args));
        }
        protected override void AssertMainException(string messagePrefix, Exception exception)
        {

            System.Net.WebException webException = (System.Net.WebException)((AggregateException)exception).Flatten().InnerException!;
            AssertWebExceptionType(messagePrefix, webException);
        }

        protected override string DefaultUrl => Program.DefaultUrl;
    }
}
