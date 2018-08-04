using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_07.Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void PropertyName()
        {
            bool called = false;
            Person person = new Person("Inigo Montoya");
            person.PropertyChanged += (sender, eventArgs) =>
            {
                Assert.AreEqual(
                    nameof(AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_07.Person.Name), 
                    eventArgs.PropertyName);
                called = true;
            };
            person.Name = "Princess Buttercup";
            Assert.IsTrue(called);
        }
    }
}