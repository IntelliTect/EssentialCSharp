using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_55.Tests;

[TestClass]
public class EmployeeTests
{
    [TestMethod]
    public async Task Employee_ReadonlyField_CompileErrorCS0191()
    {
        await CompilerAssert.CompileAsync("Listing06.54.DeclaringAFieldAsReadonly", "CS0191");
    }
}
