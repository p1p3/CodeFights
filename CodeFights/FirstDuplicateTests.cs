using CodeFights.Solutions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeFights.Tests
{
    [TestClass]
    public class FirstDuplicateTests
    {
        [TestMethod]
        public void Test1()
        {
            var result = FirstDuplicate.firstDuplicate(new[] { 2, 1, 3, 4, 3, 2 });
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Test2()
        {
            var result = FirstDuplicate.firstDuplicate(new[] { 2, 4, 3, 5, 1 });
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Test3()
        {
            var result = FirstDuplicate.firstDuplicate(new[] { 1 });
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Test4()
        {
            var result = FirstDuplicate.firstDuplicate(new[] { 2, 1 });
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Test7()
        {
            var result = FirstDuplicate.firstDuplicate(new[] { 2, 3, 3 });
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Test8()
        {
            var result = FirstDuplicate.firstDuplicate(new[] { 3, 3, 3 });
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Test11()
        {
            var result = FirstDuplicate.firstDuplicate(new[] { 1, 1, 2, 2, 1 });
            Assert.AreEqual(1, result);
        }
    }
}
