using Microsoft.VisualStudio.TestTools.UnitTesting;
using kata_34;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata_34.Tests
{
    [TestClass()]
    public class kata34Tests
    {
        [TestMethod()]
        public void PersistenceTest()
        {
            Assert.AreEqual(3, kata34.Persistence(39));
            Assert.AreEqual(0, kata34.Persistence(4));
            Assert.AreEqual(2, kata34.Persistence(25));
            Assert.AreEqual(4, kata34.Persistence(999));
        }
    }
}