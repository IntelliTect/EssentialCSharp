namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_30B
{
    public class Program
    {
        public static void ChapterMain()
        {
            {
                (string address1, string city, string countyProvinceState, string zip, string country) =
                 ("221B Baker Street", "Marylebone", "London", "NW1 6XE", "England");

                System.Console.WriteLine("Sherlock Holme's address was:");
                System.Console.WriteLine(address1);
                System.Console.WriteLine($"{city}, {countyProvinceState}  {zip}");
                System.Console.WriteLine(country);

            }
            {
                var (address1, city, countyProvinceState, zip, country) =
                    ("221B Baker Street", "Marylebone", "London", "NW1 6XE", "England");

                System.Console.WriteLine("Sherlock Holme's address was:");
                System.Console.WriteLine(address1);
                System.Console.WriteLine($"{city}, {countyProvinceState}  {zip}");
                System.Console.WriteLine(country);
            }
            {
                var address = (Address1: "221B Baker Street", City: "Marylebone", CountyProvinceState: "London", Zip: "NW1 6XE", Country: "England");

                System.Console.WriteLine("Sherlock Holme's address was:");
                System.Console.WriteLine(address.Address1);
                System.Console.WriteLine($"{address.City}, {address.CountyProvinceState}  {address.Zip}");
                System.Console.WriteLine(address.Country);

            }
            {
                var address = ("221B Baker Street", "Marylebone", "London", "NW1 6XE", "England");
                System.Console.WriteLine("Sherlock Holme's address was:");
                System.Console.WriteLine(address.Item1);
                System.Console.WriteLine($"{address.Item2}, {address.Item3}  {address.Item4}");
                System.Console.WriteLine(address.Item5);
            }
            (string Name, string _, double Gdp) countryInfo =
    ("Malawi", "Lilongwe", 226.50);
            (string Name,  string blah, double Gdp) = countryInfo;

        }
    }
}
