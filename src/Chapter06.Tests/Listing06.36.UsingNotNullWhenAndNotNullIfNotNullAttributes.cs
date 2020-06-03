using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_36
{
    [TestClass]
    public class NullabilityAttributesExaminedTests
    {
        [TestMethod]
        public void TryGetAsText_Given4_ReturnFour()
        {
            if(NullabilityAttributesExamined.TryGetDigitAsText('4', out string? text))
            {
                Assert.AreEqual<string>("four", text);
            }
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
}
