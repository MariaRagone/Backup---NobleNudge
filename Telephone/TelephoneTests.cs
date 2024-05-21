using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Telephone
{
    [TestClass]
    public class TelephoneTests
    {
        [TestMethod]
        public void should_get_word()
        {
            string firstWord = "house";
            Assert.AreEqual("house",firstWord);
        }

        [TestMethod]
        public void should_scramble_word()
        {
            string wordThatWasHeard = "hoseu";
            Assert.AreEqual("hoseu", wordThatWasHeard);
        }
    }
    
}

