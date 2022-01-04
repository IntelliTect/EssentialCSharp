using AddisonWesley.Michaelis.EssentialCSharp.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09.Tests
{
    // Use keyword struct to declare a value type 


    [TestClass]
    public class MyTestClass
    {
        [TestMethod]// [Ignore("WIP: Currently an error is not reported when one is expected.")]
        async public Task ReadOnlyMethod_ModifyObject_ErrorReported()
        {
            string thingCode = @"
                public struct Thing
                {
                    public Thing(int number)
                    {
                        _Number = number;
                    }

                    int _Number;
                    public int Number {
                        readonly get { return _Number; }
                        set { }
                    }

                    readonly public Thing Move(int number)
                    {
                        Number = 42;
                        return new Thing(
                            Number + number);
                    }
                }";

            await CompilerAssert.ExpectErrorsAsync(thingCode,
                new CompileError("CS1604", "Cannot assign to 'Number' because it is read-only")
                );
        }
    }
}