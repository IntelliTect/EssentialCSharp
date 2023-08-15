using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_11.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void CovariantReturnTypesTest()
    {
        Derived derived1 = new();
        Derived create1 = derived1.Create();

        Base derived2 = derived1;
        Base create2 = derived2.Create();
    }
}
