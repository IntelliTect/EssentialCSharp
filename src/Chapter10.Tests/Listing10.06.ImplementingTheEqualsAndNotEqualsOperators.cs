using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_06.Tests
{
    [TestClass]
    public class ProductSerialNumberTests
    {
        [TestMethod]
        public void Equals_GivenEqualObjects_Equal()
        {
            ProductSerialNumber productSerialNumber1 = new ProductSerialNumber("12", 11, 11001);
            ProductSerialNumber productSerialNumber2 = new ProductSerialNumber("12", 11, 11001);
            
            Assert.IsTrue(productSerialNumber1.Equals(productSerialNumber2));
        }

        [TestMethod]
        [DataRow("12", 11, 11001, "14", 11, 11001)]
        [DataRow("12", 12, 11001, "12", 11, 11001)]
        [DataRow("12", 12, 11005, "12", 11, 11001)]
        public void NotEquals_GivenDifferentObjects_NotEqual(string productSeries1, int model1, int id1,
            string productSeries2 ,int model2, long id2)
        {
            ProductSerialNumber productSerialNumber1 = new ProductSerialNumber(productSeries1, model1, id1);
            ProductSerialNumber productSerialNumber2 = new ProductSerialNumber(productSeries2, model2, id2);
            
            Assert.IsTrue(productSerialNumber1 != productSerialNumber2);
        }

        [TestMethod]
        public void Equals_GivenNull_NotEqual()
        {
            ProductSerialNumber productSerialNumber1 = new ProductSerialNumber("12", 11, 11001);
            ProductSerialNumber? productSerialNumber2 = null;
            
            
            Assert.IsFalse(productSerialNumber1.Equals(productSerialNumber2!));
        }

        [TestMethod]
        public void Equals_GivenSameReference_Equal()
        {
            ProductSerialNumber productSerialNumber1 = new ProductSerialNumber("12", 11, 11001);
            ProductSerialNumber productSerialNumber2 = productSerialNumber1;
            
            Assert.IsTrue(productSerialNumber1 == productSerialNumber2);
        }

        [TestMethod]
        public void Equals_GivenDifferentTypes_NotEqual()
        {
            ProductSerialNumber productSerialNumber1 = new ProductSerialNumber("12", 11, 11001);
            int otherObj = 12;
            
            Assert.IsFalse(productSerialNumber1.Equals(otherObj));
        }
    }
}
