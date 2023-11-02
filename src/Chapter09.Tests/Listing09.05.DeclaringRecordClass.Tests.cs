namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_05.Tests;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_02;
using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_07;

[TestClass]
public partial class CoordinateTests
{
    [TestMethod]
    public void With_Coordinate_IsReadOnly()
    {
        Coordinate coordinate1 = new(
            new Angle(180, 0, 0), new Angle(180, 0, 0));
        Coordinate coordinate2 = coordinate1 with {  };

        Assert.AreEqual<Coordinate>(coordinate1, coordinate2);
    }

    [TestMethod]
    public void EqualityContract_GetType()
    {
        Coordinate coordinate1 = new(
            new Angle(180, 0, 0), new Angle(180, 0, 0));
        NamedCoordinate coordinate2 = new(
            coordinate1.Longitude, coordinate1.Latitude, "Test");

        Assert.AreNotEqual<Type>(coordinate1.GetType(), coordinate2.GetType());
    }

    record struct SampleStruct(int A, int B)
    {
        int C { get; set; }
    }
    
    [TestMethod]
    public void GetHashCode_ChangeData_GetHashCodeChanges()
    {
        SampleStruct sample1 = new(1, 2);
        int expected = sample1.GetHashCode();
        sample1.A = 3;
        Assert.AreNotEqual<int>(expected, sample1.GetHashCode());
    }


    [TestMethod]
    public void GetHashCode_StoredInDictionary_NotFoundWhenChanged()
    {
        SampleStruct sample = new(1, 2);
        Dictionary<SampleStruct, string> dictionary = new() { { sample, "" } };
        sample.A = 3;
        Assert.IsFalse(dictionary.ContainsKey(sample));
    }


    [TestMethod]
    public void GetHashCode_OnTuplesStoredInDictionary_NotFoundWhenChanged()
    {
        (int A, int B) tuple = new(1, 2);
        Dictionary<(int A, int B), string> dictionary = new() { { tuple, "" } };
        tuple.A = 3;
        Assert.IsFalse(dictionary.ContainsKey(tuple));
    }
    
    [TestMethod]
    public void ToString_GivenAdditionalProperty_IgnoredInOutput()
    {
        SampleStruct sampleStruct = new(1, 2);
        Assert.AreEqual<string>("SampleStruct { A = 1, B = 2 }", sampleStruct.ToString());
    }
    
    [TestMethod]
    public void With_Instance_Equivalent()
    {
        Coordinate coordinate1 = new(
            new Angle(180, 0, 0), new Angle(180, 0, 0));
        Coordinate coordinate2 = coordinate1 with { };
        Assert.AreEqual(coordinate1, coordinate2);
    }

    [TestMethod]
    public void With_DifferentInstance_NotEquivalent()
    {
        Coordinate coordinate1 = 
            new(new Angle(180, 0, 0), new Angle(180, 0, 0));
        Angle angle = new(0, 0, 0);
        Coordinate coordinate2 = coordinate1 with
        {
            Latitude  = angle
        };
        Assert.AreNotEqual(coordinate1, coordinate2);
    }
}
