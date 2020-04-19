namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Table03_01
{
    public class TupleDeclarationAndAssigment
    {
        // 1.
        public void AssignTupleToIndividuallyDeclaredVaraibles()
        {
            (string country, string capital, double gdpPerCapita) =
                ("South Sudan", "Juba", 275.18);
            System.Console.WriteLine(
                $@"The poorest country in the world in 2017 was {
                    country}, {capital}: {gdpPerCapita}");
        }

        // 2.
        public void AssignTupleToIndividuallyDeclaredVariablesThatArPreDeclared()
        {
            string country;
            string capital;
            double gdpPerCapita;

            (country, capital, gdpPerCapita) =
                ("South Sudan", "Juba", 275.18);
            System.Console.WriteLine(
                $@"The poorest country in the world in 2017 was {
                    country}, {capital}: {gdpPerCapita}");
        }

        // 3.
        public void AssignTupleToIndividuallyDeclaredAndImplicitlyTypedVariables()
        {
            (var country, var capital, var gdpPerCapita) =
                ("South Sudan", "Juba", 275.18);
            System.Console.WriteLine(
                $@"The poorest country in the world in 2017 was {
                    country}, {capital}: {gdpPerCapita}");
        }

        // 4.
        public void AssignTupleToIndividuallyDeclaredVariablesThatImplicitlyTypedWithADistributiveSyntax()
        {
            var (country, capital, gdpPerCapita) =
                ("South Sudan", "Juba", 275.18);
            System.Console.WriteLine(
                $@"The poorest country in the world in 2017 was {
                    country}, {capital}: {gdpPerCapita}");
        }

        // 5.
        public void DeclareANamedItemTupleAndAssignItTupleValuesAndThenAccessTheTupleItemsByName()
        {
            (string Name, string Capital, double GdpPerCapita) countryInfo =
                ("South Sudan", "Juba", 275.18);
            System.Console.WriteLine(
                $@"The poorest country in the world in 2017 was {
                    countryInfo.Name}, {countryInfo.Capital}: {
                    countryInfo.GdpPerCapita}");
        }

        // 6.
        public void AssignANamedItemTupleToASingleImplicitlyTypedVariableThatIsImplicitlyTypedAndThenAccessTheTupleItemsByName()
        {
            var countryInfo =
                (Name: "South Sudan", Capital: "Juba", GdpPerCapita: 275.18);
            System.Console.WriteLine(
              $@"The poorest country in the world in 2017 was {
              countryInfo.Name}, {countryInfo.Capital}: {
              countryInfo.GdpPerCapita}");

        }

        // 7.
        public void AssignAnUnnamedTupleToASingleImplicitlyTypedVariableAndThenAccessTheTupleElementsByTheirItemNumberProperty()
        {
            var countryInfo =
                ("South Sudan", "Juba", 275.18);
            System.Console.WriteLine(
              $@"The poorest country in the world in 2017 was {
              countryInfo.Item1}, {countryInfo.Item2}: {
              countryInfo.Item3}");
        }

        // 8.
        public void AssignANamedItemTupleToASingleImplicitlyTypedVariableAndThenAccessTheTupleItemsByTheirItemNumberProperty()
        {
            var countryInfo =
                (Name: "South Sudan", Capital: "Juba", GdpPerCapita: 275.18);
            System.Console.WriteLine(
              $@"The poorest country in the world in 2017 was {
              countryInfo.Item1}, {countryInfo.Item2}: {
              countryInfo.Item3}");
        }

        // 9.
        public void DiscardPortionsOfTheTupleWithUnderscores()
        {
            (string name, _, double gdpPerCapita) =
                ("South Sudan", "Juba", 275.18);
        }

        // 10.
        public void TupleElementNamesCanBeInferredFromVariableAndPropertyNames()
        {
            string country = "South Sudan";
            string capital = "Juba";
            double gdpPerCapita = 275.18;

            var countryInfo =
                (country, capital, gdpPerCapita);
            System.Console.WriteLine(
                $@"The poorest country in the world in 2017 was {
                    countryInfo.country}, {countryInfo.capital}: {
                    countryInfo.gdpPerCapita}");
        }
    }
}
