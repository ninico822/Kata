using Microsoft.VisualStudio.TestTools.UnitTesting;
using keta_37;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace keta_37.Tests
{
    [TestClass()]
    public class NumberTests
    {

        [TestMethod()]
        public void DigitalRootTestNormally()
        {
            Assert.AreEqual(7, Number.DigitalRoot(16));
        }

        [TestMethod()]
        public void ZeroNumberTest()
        {
            Assert.AreEqual(0, Number.DigitalRoot(0));
        }

        [TestMethod()]
        public void LongNumberTest()
        {
            Assert.AreEqual(1, Number.DigitalRoot(12345678910));
        }

    }
}