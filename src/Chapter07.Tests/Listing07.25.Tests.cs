using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_25.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void LoadPdaItem()
        {
            PdaItem pdaItem = new PdaItem();
            Contact contact = Contact.Load(pdaItem);
            Assert.AreNotSame(pdaItem, (PdaItem)contact);
        }

        [TestMethod]
        public void LoadContact()
        {
            PdaItem pdaItem = new Contact();
            Contact contact = Contact.Load(pdaItem);
            Assert.AreSame(pdaItem, (PdaItem)contact);
        }
    }
}