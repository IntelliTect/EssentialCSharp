namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Table03_01;

public class TupleDeclarationAndAssignment
{
    // 1.
    public void AssignTupleToIndividuallyDeclaredVariables()
    {
        (string country, string capital, double gdpPerCapita) =
            ("Burundi", "Bujumbura", 263.67);
        Console.WriteLine(
            $@"The poorest country in the world in 2017 was {
                country}, {capital}: {gdpPerCapita}");
    }

    // 2.
    public void AssignTupleToIndividuallyDeclaredVariablesThatArePreDeclared()
    {
        string country;
        string capital;
        double gdpPerCapita;

        (country, capital, gdpPerCapita) =
            ("Burundi", "Bujumbura", 263.67);
        Console.WriteLine(
            $@"The poorest country in the world in 2017 was {
                country}, {capital}: {gdpPerCapita}");
    }

    // 3.
    public void AssignTupleToIndividuallyDeclaredAndImplicitlyTypedVariables()
    {
        (var country, var capital, var gdpPerCapita) =
            ("Burundi", "Bujumbura", 263.67);
        Console.WriteLine(
            $@"The poorest country in the world in 2017 was {
                country}, {capital}: {gdpPerCapita}");
    }

    // 4.
    public void AssignTupleToIndividuallyDeclaredVariablesThatImplicitlyTypedWithADistributiveSyntax()
    {
        var (country, capital, gdpPerCapita) =
            ("Burundi", "Bujumbura", 263.67);
        Console.WriteLine(
            $@"The poorest country in the world in 2017 was {
                country}, {capital}: {gdpPerCapita}");
    }

    // 5.
    public void DeclareANamedItemTupleAndAssignItTupleValuesAndThenAccessTheTupleItemsByName()
    {
        (string Name, string Capital, double GdpPerCapita) countryInfo =
            ("Burundi", "Bujumbura", 263.67);
        Console.WriteLine(
            $@"The poorest country in the world in 2017 was {
                countryInfo.Name}, {countryInfo.Capital}: {
                countryInfo.GdpPerCapita}");
    }

    // 6.
    public void AssignANamedItemTupleToASingleImplicitlyTypedVariableThatIsImplicitlyTypedAndThenAccessTheTupleItemsByName()
    {
        var countryInfo =
            (Name: "Burundi", Capital: "Bujumbura", GdpPerCapita: 263.67);
        Console.WriteLine(
          $@"The poorest country in the world in 2017 was {
          countryInfo.Name}, {countryInfo.Capital}: {
          countryInfo.GdpPerCapita}");
    }

    // 7.
    public void AssignAnUnnamedTupleToASingleImplicitlyTypedVariableAndThenAccessTheTupleElementsByTheirItemNumberProperty()
    {
        var countryInfo =
            ("Burundi", "Bujumbura", 263.67);
        Console.WriteLine(
          $@"The poorest country in the world in 2017 was {
          countryInfo.Item1}, {countryInfo.Item2}: {
          countryInfo.Item3}");
    }

    // 8.
// Justification: Demonstrating the fact that the name is an alias to ItemX.
#pragma warning disable IDE0033 // Use explicitly provided tuple name
    public void AssignANamedItemTupleToASingleImplicitlyTypedVariableAndThenAccessTheTupleItemsByTheirItemNumberProperty()
    {
        var countryInfo =
            (Name: "Burundi", Capital: "Bujumbura", GdpPerCapita: 263.67);
        Console.WriteLine(
          $@"The poorest country in the world in 2017 was {
          countryInfo.Item1}, {countryInfo.Item2}: {
          countryInfo.Item3}");
    }
#pragma warning restore IDE0033 // Use explicitly provided tuple name

    // 9.
    public void DiscardPortionsOfTheTupleWithUnderscores()
    {
        (string name, _, double gdpPerCapita) =
            ("Burundi", "Bujumbura", 263.67);
    }

    // 10.
    public void TupleElementNamesCanBeInferredFromVariableAndPropertyNames()
    {
        string country = "Burundi";
        string capital = "Bujumbura";
        double gdpPerCapita = 263.67;

        var countryInfo =
            (country, capital, gdpPerCapita);
        Console.WriteLine(
            $@"The poorest country in the world in 2017 was {
                countryInfo.country}, {countryInfo.capital}: {
                countryInfo.gdpPerCapita}");
    }
}
