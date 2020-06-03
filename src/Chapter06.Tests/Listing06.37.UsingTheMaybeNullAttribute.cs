using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_37
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void GetObject_CollectionWithItem_ReturnItem()
        {
            NullabilityAttributesExamined.GetObject(
                new string[] { "item" }, item => item is object);
        }

        [TestMethod]
        public void GetObject_GivenEmptyCollection_ReturnNull()
        {
            Assert.IsNull(NullabilityAttributesExamined.GetObject(
                new string[] { }, item => item is object));
        }

        [TestMethod]
        public void GetObject_ViaMethod_ReturnNull()
        {
            Assert.IsNull(NullabilityAttributesExamined.Method());
        }
    }
}
