using System.Collections;
using CodeFights.Solutions;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeFights.Tests
{
    [TestClass]
    public class RotateImageTests
    {
        [TestMethod]
        public void Test1()
        {
            var input = new[] { new[] { 1, 2, 3 },
                                new[] { 4, 5, 6 },
                                new[] { 7, 8, 9 } };

            var result = RotateImage.rotateImage(input);

            var expectedResult = new[] { new[] { 7, 4, 1 },
                new[] { 8, 5, 2},
                new[] { 9, 6, 3 } };

            CollectionAssert.AreEqual(expectedResult, result, new CollectionAssertComperator());
        }

        [TestMethod]
        public void Test2()
        {
            var input = new[] { new[] { 1 } };

            var result = RotateImage.rotateImage(input);

            var expectedResult = new[] { new[] { 1 } };

            CollectionAssert.AreEqual(expectedResult, result, new CollectionAssertComperator());
        }

        [TestMethod]
        public void Test3()
        {
            var input = new[] { new[] {10, 9, 6, 3, 7},
                new[] { 6, 10, 2, 9, 7 },
                new[] { 7, 6, 3, 8, 2 },
                new[] { 8, 9, 7, 9, 9},
                new[] { 6, 8, 6, 8, 2},
            };

            var result = RotateImage.rotateImage(input);

            var expectedResult = new[] { new[] {6, 8, 7, 6, 10},
                new[] { 8, 9, 6, 10, 9 },
                new[] { 6, 7, 3, 2, 6 },
                new[] { 8, 9, 8, 9, 3},
                new[] { 2, 9, 2, 7, 7},
            };


            CollectionAssert.AreEqual(expectedResult, result, new CollectionAssertComperator());
        }
    }

    class CollectionAssertComperator : IComparer
    {
        public int Compare(object x, object y)
        {
            CollectionAssert.AreEqual((ICollection)x, (ICollection)y);
            return 0;
        }
    }
}