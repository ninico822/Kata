using Microsoft.VisualStudio.TestTools.UnitTesting;
using kata_31;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata_31.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void EncodeTest()
        {
            CollectionAssert.AreEqual(new List<int> { 20, 12, 18, 30, 21 }, Program.Encode("scout", 1939));
            CollectionAssert.AreEqual(new List<int> { 14, 10, 22, 29, 6, 27, 19, 18, 6, 12, 8 }, Program.Encode("masterpiece", 1939));
        }

        [TestMethod()]
        public void CharToIndexOfValue()
        {
            char[] testStrArr = {'s', 'c', 'o', 'u', 't'};
            CollectionAssert.AreEqual(new List<int> { 19,3,15,21,20 }, Program.GetIndexOfValue(testStrArr));
        }


    }
}