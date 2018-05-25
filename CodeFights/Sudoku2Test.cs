using CodeFights.Solutions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeFights.Tests
{
    [TestClass]
    public class Sudoku2Test
    {
        [TestMethod]
        public void Test1()
        {
            var input = new[] {
                new[] { '.','.','.','1','4','.','.','2','.'},
                new[] { '.','.','6','.','.','.','.','.','.' },
                new[] { '.','.','.','.','.','.','.','.','.' },
                new[] { '.','.','1','.','.','.','.','.','.' },
                new[] { '.','6','7','.','.','.','.','.','9' },
                new[] { '.','.','.','.','.','.','8','1','.' },
                new[] { '.','3','.','.','.','.','.','.','6' },
                new[] { '.','.','.','.','.','7','.','.','.' },
                new[] { '.','.','.','5','.','.','.','7','.' },
            };


            var result = Sudoku2.sudoku2(input);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test2()
        {
            var input = new[] {
                new[] { '.','.','.','.','2','.','.','9','.'  },
                new[] { '7','1','.','.','7','5','.','.','.'  },
                new[] { '.','7','.','.','.','.','.','.','.' },
                new[] { '.','.','.','.','8','3','.','.','.' },
                new[] { '.','.','8','.','.','7','.','6','.' },
                new[] { '.','.','.','.','.','2','.','.','.' },
                new[] { '.','1','.','2','.','.','.','.','.' },
                new[] { '.','.','.','.','.','7','.','.','.' },
                new[] { '.','2','.','.','3','.','.','.','.' },
            };
            

            var result = Sudoku2.sudoku2(input);
            Assert.IsFalse(result);
        }
    }
}
