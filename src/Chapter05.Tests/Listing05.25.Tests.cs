
using IntelliTect.TestTools.Console;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_25.Tests;

[TestClass]
public class SpecifyingParametersByNameTests
{
    [TestMethod]
    public void SpecifyingParametersByName_WithNamedParameters_WritesToConsole()
    {
        const string expected = "First Name: Inigo Middle Name:  Last Name: Montoya";

        ConsoleAssert.Expect(expected, () => SpecifyingParametersByName.Main());
    }

    [TestMethod]
    public void SpecifyingParametersByName_WithNamedParametersInReverseOrder_WritesToConsole()
    {
        const string expected = "First Name: Inigo Middle Name: MiddleName Last Name: Montoya";

        ConsoleAssert.Expect(expected, () => SpecifyingParametersByName.DisplayGreeting(firstName: "Inigo", middleName: "MiddleName", lastName: "Montoya"));
    }
}
