using AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_13to14.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_15.Tests
{

    [TestClass]
    public class ProgramTests : BaseProgramTests<Task<int>>
    {
        [ClassInitialize]
        static public void ClassInitialize(TestContext textContext)
        {
            ProgramWrapper = new ProgramWrapper<Task<int>>(
                (string[] args)=>Program.Main(args).AsTask().Wait());
        }

        protected override void AssertExceptionTypeAndMessage(string messagePrefix, Exception exception)
        {
            Assert.AreEqual<Type>(typeof(AggregateException), exception.GetType());  // Testing type first (even though the cast will also verify)

            AssertAggregateExceptionType(messagePrefix, (AggregateException)exception);
        }
    }
}
