
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_14.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Address_ToString()
    {
        Address address = new();
        address.StreetAddress = "111 W St";
        address.City = "City";
        address.State = "State";
        address.Zip = "11111";

        string expected = "111 W St" + System.Environment.NewLine +
                          "City, State  11111";
        
        Assert.AreEqual(expected, address.ToString());
    }
    
    [TestMethod]
    public void InternationalAddress_ToString_CallBaseImplementation()
    {
        InternationalAddress internationalAddress = new();
        internationalAddress.StreetAddress = "111 W St";
        internationalAddress.City = "City";
        internationalAddress.State = "State";
        internationalAddress.Zip = "11111";
        internationalAddress.Country = "Country";

        string expected = "111 W St" + System.Environment.NewLine +
                          "City, State  11111" + System.Environment.NewLine +
                          "Country";
        
        Assert.AreEqual(expected, internationalAddress.ToString());
    }
}
