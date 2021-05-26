using BinarySearch;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinarySearchTest
{
    [TestClass]
    public class IterativeSolutionTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] data = { 2, 3, 4, 10, 40 };
            Assert.AreEqual(3, new IterativeSolution().BinarySearch(data, 0, data.Length - 1, 10));
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] data = { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18 };
            Assert.AreEqual(-1, new IterativeSolution().BinarySearch(data, 0, data.Length - 1, 9));
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] data = { 0, 2, 4, 6, 8, 10, 12, 14, 16 };
            Assert.AreEqual(0, new IterativeSolution().BinarySearch(data, 0, data.Length - 1, 0));
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] data = { 0, 2, 4, 6, 8, 10, 12, 14, 16 };
            Assert.AreEqual(8, new IterativeSolution().BinarySearch(data, 0, data.Length - 1, 16));
        }

        [TestMethod]
        public void TestMethod5()
        {
            int[] data = { 0, 2, 4, 6, 8, 10, 12, 14, 16 };
            Assert.AreEqual(4, new IterativeSolution().BinarySearch(data, 0, data.Length - 1, 8));
        }
    }
}
