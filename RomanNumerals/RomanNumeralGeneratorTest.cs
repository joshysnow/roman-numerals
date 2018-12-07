using NUnit.Framework;
using System;

namespace RomanNumerals
{
    [TestFixture()]
    public class RomanNumeralGeneratorTest
    {
        private RomanNumeralGenerator _generator = new RomanNumeralGenerator();

        [Test()]
        public void Translate_1_I()
        {
            string result = _generator.Generate(1);
            Assert.AreEqual("I", result);
        }
    }
}
