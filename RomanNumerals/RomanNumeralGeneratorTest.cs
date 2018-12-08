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
        public void Translate_11_XI()
        {
            string result = _generator.Generate(11);
            Assert.AreEqual("XI", result);
        }

        [Test()]
        public void Translate_12_XII()
        {
            string result = _generator.Generate(12);
            Assert.AreEqual("XII", result);
        }

        [Test()]
        public void Translate_15_XV()
        {
            string result = _generator.Generate(15);
            Assert.AreEqual("XV", result);
        }

        [Test()]
        public void Translate_19_XIX()
        {
            string result = _generator.Generate(19);
            Assert.AreEqual("XIX", result);
        }

        [Test()]
        public void Translate_20_XX()
        {
            string result = _generator.Generate(20);
            Assert.AreEqual("XX", result);
        }

        [Test()]
        public void Translate_25_XXV()
        {
            string result = _generator.Generate(25);
            Assert.AreEqual("XXV", result);
        }

        [Test()]
        public void Translate_30_XXX()
        {
            string result = _generator.Generate(30);
            Assert.AreEqual("XXX", result);
        }

        [Test()]
        public void Translate_35_XXXV()
        {
            string result = _generator.Generate(35);
            Assert.AreEqual("XXXV", result);
        }

        [Test()]
        public void Translate_40_XL()
        {
            string result = _generator.Generate(40);
            Assert.AreEqual("XL", result);
        }

        [Test()]
        public void Translate_45_XLV()
        {
            string result = _generator.Generate(45);
            Assert.AreEqual("XLV", result);
        }
    }
}
