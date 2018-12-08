using NUnit.Framework;
using System;

namespace RomanNumerals
{
    [TestFixture()]
    public class RomanNumeralGeneratorTest
    {
        private RomanNumeralGenerator _generator = new RomanNumeralGenerator();

        [Test()]
        public void Translate_0()
        {
            string result = _generator.Generate(0);
            Assert.AreEqual(string.Empty, result);
        }

        [Test()]
        public void Translate_1_I()
        {
            string result = _generator.Generate(1);
            Assert.AreEqual("I", result);
        }

        [Test()]
        public void Translate_2_II()
        {
            string result = _generator.Generate(2);
            Assert.AreEqual("II", result);
        }

        [Test()]
        public void Translate_3_III()
        {
            string result = _generator.Generate(3);
            Assert.AreEqual("III", result);
        }

        [Test()]
        public void Translate_4_IV()
        {
            string result = _generator.Generate(4);
            Assert.AreEqual("IV", result);
        }

        [Test()]
        public void Translate_5_V()
        {
            string result = _generator.Generate(5);
            Assert.AreEqual("V", result);
        }

        [Test()]
        public void Translate_6_VI()
        {
            string result = _generator.Generate(6);
            Assert.AreEqual("VI", result);
        }

        [Test()]
        public void Translate_7_VII()
        {
            string result = _generator.Generate(7);
            Assert.AreEqual("VII", result);
        }

        [Test()]
        public void Translate_8_VIII()
        {
            string result = _generator.Generate(8);
            Assert.AreEqual("VIII", result);
        }

        [Test()]
        public void Translate_9_IX()
        {
            string result = _generator.Generate(9);
            Assert.AreEqual("IX", result);
        }

        [Test()]
        public void Translate_10_X()
        {
            string result = _generator.Generate(10);
            Assert.AreEqual("X", result);
        }

        [Test()]
        public void Translate_20_XX()
        {
            string result = _generator.Generate(20);
            Assert.AreEqual("XX", result);
        }
    }
}
