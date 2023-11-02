
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_41.Tests;

[TestClass]
public class NullabilityAttributesExaminedTests
{
    [TestMethod]
    public void TryGetAsText_Given4_ReturnFour()
    {
        Assert.IsTrue(NullabilityAttributesExamined.TryGetDigitAsText('4', out string? text));
        Assert.AreEqual<string>("four", text);
    }


    [TestMethod]
    public void TryGetAsText_GivenX_ReturnFalse()
    {
        Assert.IsFalse(NullabilityAttributesExamined.TryGetDigitAsText('X', out _));
    }

    [TestMethod]
    public void TryGetAsText_GivenX4X2_ReturnFourTwo()
    {
        Assert.AreEqual<string>("four-two", 
            NullabilityAttributesExamined.TryGetDigitsAsText("X4X2"));

        Assert.AreEqual<string?>(null,
            NullabilityAttributesExamined.TryGetDigitsAsText(null));
    }
}
