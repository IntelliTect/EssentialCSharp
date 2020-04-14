using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_03.Tests
{
    [TestClass]
    public class ContactTests
    {
        [TestMethod]
        public void CompareTo_ObjIsNull_Return1()
        {
            Contact contact = new Contact("Inigo Montoya");
            
            Assert.AreEqual(1, contact.CompareTo(null));
        }

        [TestMethod]
        public void CompareTo_ThisSmallerThanObj_ReturnNegative1()
        {
            Contact firstContact = new Contact("Inigo Montoya");
            Contact secondContact = new Contact("Zero Zero");
            
            Assert.AreEqual(-1, firstContact.CompareTo(secondContact));
        }

        [TestMethod]
        public void CompareTo_ThisLargerThanObj_Return1()
        {
            Contact firstContact = new Contact("Zero Zero");
            Contact secondContact = new Contact("Inigo Montoya");
            
            Assert.AreEqual(1, firstContact.CompareTo(secondContact));
        }

        [TestMethod]
        public void CompareTo_ObjIsSameReferenceAsThis_Return0()
        {
            Contact firstContact = new Contact("Inigo Montoya");
            Contact secondContact = firstContact;
            
            Assert.AreEqual(0, firstContact.CompareTo(secondContact));
        }

        [TestMethod]
        public void CompareTo_LastNamesAreTheSame_Return1()
        {
            Contact firstContact = new Contact("Zero Montoya");
            Contact secondContact = new Contact("Inigo Montoya");
            
            Assert.AreEqual(1, firstContact.CompareTo(secondContact));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CompareTo_ObjIsNotInstanceOfObject_ArgumentException()
        {
            Contact firstContact = new Contact("Inigo Montoya");
            string someString = "test";

            firstContact.CompareTo(someString);
        }
    }
}
