namespace ByndyusoftTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SimpleTest()
        {
            double?[] array = { 3, 2, 4 };
            Assert.AreEqual(5, ArrayExt.CalcSum2Min(array));
        }

        [TestMethod]
        public void SimpleTest2()
        {
            double?[] array = { -5, 2, -7, -1, -1, 10, 0, 0, -5 };
            Assert.AreEqual(-12, ArrayExt.CalcSum2Min(array));
        }

        [TestMethod]
        public void SimpleTest3()
        {
            double?[] array = { 1, 1 };
            Assert.AreEqual(2, ArrayExt.CalcSum2Min(array));
        }

        [TestMethod]
        public void SimpleTest4()
        {
            double?[] array = { 1, 1, 0.1, 1, 1, 0, 0 };
            Assert.AreEqual(0, ArrayExt.CalcSum2Min(array));
        }

        [TestMethod]
        public void TestFromTask()
        {
            double?[] array = { 4, 0, 3, 19, 492, -10, 1 };
            Assert.AreEqual(-10, ArrayExt.CalcSum2Min(array));
        }

        [TestMethod]
        public void EmptyTest1()
        {
            double?[] array = { };
            Assert.ThrowsException<ArgumentException>(() => ArrayExt.CalcSum2Min(array));
        }

        [TestMethod]
        public void EmptyTest2()
        {
            Assert.ThrowsException<ArgumentNullException>(() => ArrayExt.CalcSum2Min(null));
        }

        [TestMethod]
        public void WithNullTest()
        {
            double?[] array = {0, 1, null, 3 };
            Assert.ThrowsException<NullReferenceException>(() => ArrayExt.CalcSum2Min(array));
        }
    }
}