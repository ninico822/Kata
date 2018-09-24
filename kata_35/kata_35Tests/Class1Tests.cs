using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace kata_35.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void GetVowelCountTestNormally()
        {
            Assert.AreEqual(5, Class1.GetVowelCount("abracadabra"));
        }

        [TestMethod()]
        public void SpaceStringTest()
        {
            Assert.AreEqual(5, Class1.GetVowelCount("ab rac ada bra"));
        }

        [TestMethod()]
        public void AllVowelStringTest()
        {
            Assert.AreEqual(13, Class1.GetVowelCount("aeiouioeaioue"));
        }

        [TestMethod()]
        public void NoneStringTest()
        {
            Assert.AreEqual(0, Class1.GetVowelCount(" "));
        }
    }
}