namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Table03_01.Tests;

[TestClass]
public class TupleDeclarationAndAssignmentTests
{
    private readonly TupleDeclarationAndAssignment _sut = new();

    [TestMethod]
    public void AssignTupleToIndividuallyDeclaredVariables()
    {
        string expected = $"The poorest country in the world in 2017 was Burundi, Bujumbura: {263.67}";
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            _sut.AssignTupleToIndividuallyDeclaredVariables);
    }

    [TestMethod]
    public void AssignTupleToIndividuallyDeclaredVariablesThatArePreDeclared()
    {
        string expected = $"The poorest country in the world in 2017 was Burundi, Bujumbura: {263.67}";
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            _sut.AssignTupleToIndividuallyDeclaredVariablesThatArePreDeclared);
    }

    [TestMethod]
    public void AssignTupleToIndividuallyDeclaredAndImplicitlyTypedVariables()
    {
        string expected = $"The poorest country in the world in 2017 was Burundi, Bujumbura: {263.67}";
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            _sut.AssignTupleToIndividuallyDeclaredAndImplicitlyTypedVariables);
    }

    [TestMethod]
    public void AssignTupleToIndividuallyDeclaredVariablesThatImplicitlyTypedWithADistributiveSyntax()
    {
        string expected = $"The poorest country in the world in 2017 was Burundi, Bujumbura: {263.67}";
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            _sut.AssignTupleToIndividuallyDeclaredVariablesThatImplicitlyTypedWithADistributiveSyntax);
    }

    [TestMethod]
    public void DeclareANamedItemTupleAndAssignItTupleValuesAndThenAccessTheTupleItemsByName()
    {
        string expected = $"The poorest country in the world in 2017 was Burundi, Bujumbura: {263.67}";
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            _sut.DeclareANamedItemTupleAndAssignItTupleValuesAndThenAccessTheTupleItemsByName);
    }

    [TestMethod]
    public void AssignANamedItemTupleToASingleImplicitlyTypedVariableThatIsImplicitlyTypedAndThenAccessTheTupleItemsByName()
    {
        string expected = $"The poorest country in the world in 2017 was Burundi, Bujumbura: {263.67}";
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            _sut.AssignANamedItemTupleToASingleImplicitlyTypedVariableThatIsImplicitlyTypedAndThenAccessTheTupleItemsByName);
    }

    [TestMethod]
    public void AssignAnUnnamedTupleToASingleImplicitlyTypedVariableAndThenAccessTheTupleElementsByTheirItemNumberProperty()
    {
        string expected = $"The poorest country in the world in 2017 was Burundi, Bujumbura: {263.67}";
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            _sut.AssignAnUnnamedTupleToASingleImplicitlyTypedVariableAndThenAccessTheTupleElementsByTheirItemNumberProperty);
    }

    [TestMethod]
    public void AssignANamedItemTupleToASingleImplicitlyTypedVariableAndThenAccessTheTupleItemsByTheirItemNumberProperty()
    {
        string expected = $"The poorest country in the world in 2017 was Burundi, Bujumbura: {263.67}";
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            _sut.AssignANamedItemTupleToASingleImplicitlyTypedVariableAndThenAccessTheTupleItemsByTheirItemNumberProperty);
    }

    [TestMethod]
    public void TupleElementNamesCanBeInferredFromVariableAndPropertyNames()
    {
        string expected = $"The poorest country in the world in 2017 was Burundi, Bujumbura: {263.67}";
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
            _sut.TupleElementNamesCanBeInferredFromVariableAndPropertyNames);
    }
}