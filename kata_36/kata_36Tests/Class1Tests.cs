using Microsoft.VisualStudio.TestTools.UnitTesting;
using kata_36;


namespace kata_36Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void FindTestNormally()
        {
            int[] exampleTest1 = { 2, 6, 8, -10, 3 };
            Assert.IsTrue(3 == Class1.Find(exampleTest1));
        }

        [TestMethod()]
        public void FindTestLongParams()
        {
            int[] exampleTest2 = { 206847684, 1056521, 7, 17, 1901, 21104421, 7, 1, 35521, 1, 7781 };
            Assert.IsTrue(206847684 == Class1.Find(exampleTest2));
        }

        [TestMethod()]
        public void FindTestMaxValue()
        {
            int[] exampleTest3 = { int.MaxValue, 0, 1 };
            Assert.IsTrue(0 == Class1.Find(exampleTest3));
        }
    }
}