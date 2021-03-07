using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagrama;
using System;

namespace AnagramaTest
{
    [TestClass]
    public class AnagramTest
    {
        private Anagram angrm;
    
        [TestInitialize]
        public void Initialize()
        {
            angrm = new Anagram();
        }

        [TestMethod]
        public void CheckStringTest()
        {
            //Arrange
            string input = "gh45iop!is ty3kl12 12hjqw!2klu7";
            //act
            var anagram = angrm.GetOutput(input);
            // Assert
            Assert.AreEqual("si45poi!hg lk3yt12 12ulkw!2qjh7", anagram);
        }


        [TestMethod]
        public void CheckStringMultipleSpacesTest()
        {
            string input = "gh45iop!is    ty3kl12";
            var anagram = angrm.GetOutput(input);

            Assert.AreEqual("si45poi!hg    lk3yt12", anagram);
        }

        [TestMethod]
        public void CheckStringMultipleSpacesOnStartTest()
        {
            string input = "   gh45iop!is    ty3kl12";
            var anagram = angrm.GetOutput(input);

            Assert.AreEqual("   si45poi!hg    lk3yt12", anagram);
        }

        [TestMethod]
        public void CheckStringMultipleSpacesOnEndTest()
        {
            string input = "gh45iop!is    ty3kl12  ";
            var anagram = angrm.GetOutput(input);

            Assert.AreEqual("si45poi!hg    lk3yt12  ", anagram);
        }

        [TestMethod]
        public void CheckStringMultipleSpacesOnStartEndTest()
        {
            string input = "   gh45iop!is    ty3kl12  ";
            var anagram = angrm.GetOutput(input);

            Assert.AreEqual("   si45poi!hg    lk3yt12  ", anagram);
        }

        [TestMethod]
        public void CheckStringMultipleSpacesAndShortWordTest()
        {
            string input = "1v   gh45iop!is    ty3kl12  ";
            var anagram = angrm.GetOutput(input);

            Assert.AreEqual("1v   si45poi!hg    lk3yt12  ", anagram);
        }

        [TestMethod]

        public void CheckNullStringTest()
        {
            string input = null;
            Assert.ThrowsException<Exception>(() => angrm.GetOutput(input));
        }

        [TestMethod]
        public void CheckEmptyStringTest()
        {
            var input = string.Empty;
            Assert.ThrowsException<Exception>(() => angrm.GetOutput(input));
        }

    }
}
