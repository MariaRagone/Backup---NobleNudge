using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Telephone
{
    [TestClass]
    public class TelephoneTests
    {
        public string firstWord = "house";
        [TestMethod]
        public void should_get_word()
        {
            Assert.AreEqual("house",firstWord);
        }
        [TestMethod]
        public void should_return_random_number()
        {
            int minValue = 1; 
            int maxValue = 10;
            Assert.IsTrue(Telephone.GetRandomNumber() >= minValue && Telephone.GetRandomNumber() <= maxValue);
        }
        [TestMethod]
        public void should_scramble_word()
        {
            string wordThatWasHeard = Telephone.ScrambleWord(firstWord);
            Assert.AreEqual("hoseu", wordThatWasHeard);
        }
    }
    
}

