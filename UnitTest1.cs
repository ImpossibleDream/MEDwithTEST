using Microsoft.VisualStudio.TestTools.UnitTesting;
using MED;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MED_Test()
        {
            string before = "banana";
            string after = "baanan";
            Assert.AreEqual(2, getMED.MED(before, after)) ;
        }
    }
}
