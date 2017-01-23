using AlgoritmsCodingBat;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsAlgoritmsCodingBat
{
    [TestClass]
    public class TestsString_1
    {

        internal String_1 String1 = new String_1();

        [TestMethod]
        public void TestLastChars()
        {
            Assert.AreEqual("ls", String1.LastChars("last", "chars"));
            Assert.AreEqual("ya", String1.LastChars("yo", "java"));
            Assert.AreEqual("h@", String1.LastChars("hi", ""));
            Assert.AreEqual("@o", String1.LastChars("", "hello"));
            Assert.AreEqual("@@", String1.LastChars("", ""));
            Assert.AreEqual("ki", String1.LastChars("kitten", "hi"));
            Assert.AreEqual("kp", String1.LastChars("k", "zip"));
            Assert.AreEqual("k@", String1.LastChars("kitten", ""));
            Assert.AreEqual("kp", String1.LastChars("kitten", "zip"));
        }

        [TestMethod]
        public void TestConCat()
        {
            Assert.AreEqual("abcat", String1.ConCat("abc", "cat"));
            Assert.AreEqual("dogcat", String1.ConCat("dog", "cat"));
            Assert.AreEqual("abc", String1.ConCat("abc", ""));
            Assert.AreEqual("cat", String1.ConCat("", "cat"));
            Assert.AreEqual("pig", String1.ConCat("pig", "g"));
            Assert.AreEqual("pigdoggy", String1.ConCat("pig", "doggy"));
        }


        [TestMethod]
        public void TestLastTwo()
        {
            Assert.AreEqual("codign", String1.LastTwo("coding"));
            Assert.AreEqual("cta", String1.LastTwo("cat"));
            Assert.AreEqual("ab", String1.LastTwo("ba"));
            Assert.AreEqual("a", String1.LastTwo("a"));
            Assert.AreEqual("", String1.LastTwo(""));
        }
    }
}
