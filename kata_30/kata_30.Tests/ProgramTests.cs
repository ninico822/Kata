using Microsoft.VisualStudio.TestTools.UnitTesting;
using kata_30;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata_30.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MxdiflgTest()
        {
            string[] s1 = new string[] { "hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz" };
            string[] s2 = new string[] { "cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww" };
            Assert.AreEqual(13, Program.Mxdiflg(s1, s2));
        }

        [TestMethod()]
        public void MxdiflgTest_Empty()
        {
            string[] s1 = new string[] { "hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz" };
            string[] s2 = new string[] { };
            Assert.AreEqual(-1, Program.Mxdiflg(s1, s2));
        }

        [TestMethod()]
        public void MxdiflgTest_SameValue()
        {
            string[] s1 = new string[] { "hoqq", "bbllkw", "oox" };
            string[] s2 = new string[] { "hoqq", "bbllkw", "oox" };
            Assert.AreEqual(3, Program.Mxdiflg(s1, s2));
        }
    }
}