namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Table03_01.Tests;

[TestClass]
public class TupleDeclarationAndAssignmentTests
{
    private readonly TupleDeclarationAndAssignment _sut = new();

    [TestMethod]
    public void AssignTupleToIndividuallyDeclaredVariables()
    {
        const string expected = "The poorest country in the world in 2017 was Burundi, Bujumbura: 263.67";
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            _sut.AssignTupleToIndividuallyDeclaredVariables);
    }

    [TestMethod]
    public void AssignTupleToIndividuallyDeclaredVariablesThatArPreDeclared()
    {
        const string expected = "The poorest country in the world in 2017 was Burundi, Bujumbura: 263.67";
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            _sut.AssignTupleToIndividuallyDeclaredVariablesThatArPreDeclared);
    }

    [TestMethod]
    public void AssignTupleToIndividuallyDeclaredAndImplicitlyTypedVariables()
    {
        const string expected = "The poorest country in the world in 2017 was Burundi, Bujumbura: 263.67";
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            _sut.AssignTupleToIndividuallyDeclaredAndImplicitlyTypedVariables);
    }

    [TestMethod]
    public void AssignTupleToIndividuallyDeclaredVariablesThatImplicitlyTypedWithADistributiveSyntax()
    {
        const string expected = "The poorest country in the world in 2017 was Burundi, Bujumbura: 263.67";
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            _sut.AssignTupleToIndividuallyDeclaredVariablesThatImplicitlyTypedWithADistributiveSyntax);
    }

    [TestMethod]
    public void DeclareANamedItemTupleAndAssignItTupleValuesAndThenAccessTheTupleItemsByName()
    {
        const string expected = "The poorest country in the world in 2017 was Burundi, Bujumbura: 263.67";
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            _sut.DeclareANamedItemTupleAndAssignItTupleValuesAndThenAccessTheTupleItemsByName);
    }

    [TestMethod]
    public void AssignANamedItemTupleToASingleImplicitlyTypedVariableThatIsImplicitlyTypedAndThenAccessTheTupleItemsByName()
    {
        const string expected = "The poorest country in the world in 2017 was Burundi, Bujumbura: 263.67";
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            _sut.AssignANamedItemTupleToASingleImplicitlyTypedVariableThatIsImplicitlyTypedAndThenAccessTheTupleItemsByName);
    }

    [TestMethod]
    public void AssignAnUnnamedTupleToASingleImplicitlyTypedVariableAndThenAccessTheTupleElementsByTheirItemNumberProperty()
    {
        const string expected = "The poorest country in the world in 2017 was Burundi, Bujumbura: 263.67";
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            _sut.AssignAnUnnamedTupleToASingleImplicitlyTypedVariableAndThenAccessTheTupleElementsByTheirItemNumberProperty);
    }

    [TestMethod]
    public void AssignANamedItemTupleToASingleImplicitlyTypedVariableAndThenAccessTheTupleItemsByTheirItemNumberProperty()
    {
        const string expected = "The poorest country in the world in 2017 was Burundi, Bujumbura: 263.67";
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            _sut.AssignANamedItemTupleToASingleImplicitlyTypedVariableAndThenAccessTheTupleItemsByTheirItemNumberProperty);
    }

    [TestMethod]
    public void TupleElementNamesCanBeInferredFromVariableAndPropertyNames()
    {
        const string expected = "The poorest country in the world in 2017 was Burundi, Bujumbura: 263.67";
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            _sut.TupleElementNamesCanBeInferredFromVariableAndPropertyNames);
    }
}