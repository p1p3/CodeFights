using System;
using System.Collections.Generic;
using System.Text;
using CodeFights.Solutions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeFights.Tests
{
    [TestClass]
    public class FirstNotRepeatingCharacterTests
    {
        [TestMethod]
        public void Test1()
        {
            var result = FirstNotRepeatingCharacter.firstNotRepeatingCharacter("abacabad");
            Assert.AreEqual('c', result);
        }

        [TestMethod]
        public void Test2()
        {
            var result = FirstNotRepeatingCharacter.firstNotRepeatingCharacter("abacabaabacaba");
            Assert.AreEqual('_', result);
        }

        [TestMethod]
        public void Test3()
        {
            var result = FirstNotRepeatingCharacter.firstNotRepeatingCharacter("z");
            Assert.AreEqual('z', result);
        }

        [TestMethod]
        public void Test4()
        {
            var result = FirstNotRepeatingCharacter.firstNotRepeatingCharacter("bcb");
            Assert.AreEqual('c', result);
        }
    }
}
