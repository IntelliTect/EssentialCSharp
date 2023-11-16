using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_54.Tests;

[TestClass]
public class EmployeeTests
{
    [TestMethod]
    public async Task Employee_ReadonlyField_CompileErrorCS0191()
    {
        await CompilerAssert.CompileTestTargetFileAsync(["CS0191"]);
    }
}
