using System;
using NUnit.Framework;

namespace RomanNumerals
{
    [TestFixture]
    public class RomanNumeralGeneratorTest
    {
        private RomanNumeralGenerator _generator = new RomanNumeralGenerator();

        [Test]
        public void Translate_NEG1_throws_exception()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _generator.Generate(-1));
        }

        [Test]
        public void Translate_1_I()
        {
            string result = _generator.Generate(1);
            Assert.AreEqual("I", result);
        }

        [Test]
        public void Translate_2_II()
        {
            string result = _generator.Generate(2);
            Assert.AreEqual("II", result);
        }

        [Test]
        public void Translate_3_III()
        {
            string result = _generator.Generate(3);
            Assert.AreEqual("III", result);
        }

        [Test]
        public void Translate_4_IV()
        {
            string result = _generator.Generate(4);
            Assert.AreEqual("IV", result);
        }

        [Test]
        public void Translate_5_V()
        {
            string result = _generator.Generate(5);
            Assert.AreEqual("V", result);
        }

        [Test]
        public void Translate_6_VI()
        {
            string result = _generator.Generate(6);
            Assert.AreEqual("VI", result);
        }

        [Test]
        public void Translate_7_VII()
        {
            string result = _generator.Generate(7);
            Assert.AreEqual("VII", result);
        }

        [Test]
        public void Translate_8_VIII()
        {
            string result = _generator.Generate(8);
            Assert.AreEqual("VIII", result);
        }

        [Test]
        public void Translate_9_IX()
        {
            string result = _generator.Generate(9);
            Assert.AreEqual("IX", result);
        }

        [Test]
        public void Translate_10_X()
        {
            string result = _generator.Generate(10);
            Assert.AreEqual("X", result);
        }

        [Test]
        public void Translate_11_XI()
        {
            string result = _generator.Generate(11);
            Assert.AreEqual("XI", result);
        }

        [Test]
        public void Translate_12_XII()
        {
            string result = _generator.Generate(12);
            Assert.AreEqual("XII", result);
        }

        [Test]
        public void Translate_15_XV()
        {
            string result = _generator.Generate(15);
            Assert.AreEqual("XV", result);
        }

        [Test]
        public void Translate_19_XIX()
        {
            string result = _generator.Generate(19);
            Assert.AreEqual("XIX", result);
        }

        [Test]
        public void Translate_20_XX()
        {
            string result = _generator.Generate(20);
            Assert.AreEqual("XX", result);
        }

        [Test]
        public void Translate_25_XXV()
        {
            string result = _generator.Generate(25);
            Assert.AreEqual("XXV", result);
        }

        [Test]
        public void Translate_30_XXX()
        {
            string result = _generator.Generate(30);
            Assert.AreEqual("XXX", result);
        }

        [Test]
        public void Translate_35_XXXV()
        {
            string result = _generator.Generate(35);
            Assert.AreEqual("XXXV", result);
        }

        [Test]
        public void Translate_40_XL()
        {
            string result = _generator.Generate(40);
            Assert.AreEqual("XL", result);
        }

        [Test]
        public void Translate_45_XLV()
        {
            string result = _generator.Generate(45);
            Assert.AreEqual("XLV", result);
        }

        [Test]
        public void Translate_50_L()
        {
            string result = _generator.Generate(50);
            Assert.AreEqual("L", result);
        }

        [Test]
        public void Translate_55_LV()
        {
            string result = _generator.Generate(55);
            Assert.AreEqual("LV", result);
        }

        [Test]
        public void Translate_60_LX()
        {
            string result = _generator.Generate(60);
            Assert.AreEqual("LX", result);
        }

        [Test]
        public void Translate_65_LXV()
        {
            string result = _generator.Generate(65);
            Assert.AreEqual("LXV", result);
        }

        [Test]
        public void Translate_85_LXXXV()
        {
            string result = _generator.Generate(85);
            Assert.AreEqual("LXXXV", result);
        }

        [Test]
        public void Translate_90_XC()
        {
            string result = _generator.Generate(90);
            Assert.AreEqual("XC", result);
        }

        [Test]
        public void Translate_95_XCV()
        {
            string result = _generator.Generate(95);
            Assert.AreEqual("XCV", result);
        }

        [Test]
        public void Translate_99_XCIX()
        {
            string result = _generator.Generate(99);
            Assert.AreEqual("XCIX", result);
        }

        [Test]
        public void Translate_100_C()
        {
            string result = _generator.Generate(100);
            Assert.AreEqual("C", result);
        }

        [Test]
        public void Translate_125_CXXV()
        {
            string result = _generator.Generate(125);
            Assert.AreEqual("CXXV", result);
        }

        [Test]
        public void Translate_150_CL()
        {
            string result = _generator.Generate(150);
            Assert.AreEqual("CL", result);
        }

        [Test]
        public void Translate_175_CLXXV()
        {
            string result = _generator.Generate(175);
            Assert.AreEqual("CLXXV", result);
        }

        [Test]
        public void Translate_200_CC()
        {
            string result = _generator.Generate(200);
            Assert.AreEqual("CC", result);
        }

        [Test]
        public void Translate_225_CCXXV()
        {
            string result = _generator.Generate(225);
            Assert.AreEqual("CCXXV", result);
        }

        [Test]
        public void Translate_375_CCCLXXV()
        {
            string result = _generator.Generate(375);
            Assert.AreEqual("CCCLXXV", result);
        }

        [Test]
        public void Translate_400_CD()
        {
            string result = _generator.Generate(400);
            Assert.AreEqual("CD", result);
        }

        [Test]
        public void Translate_450_CDL()
        {
            string result = _generator.Generate(450);
            Assert.AreEqual("CDL", result);
        }

        [Test]
        public void Translate_475_CDLXXV()
        {
            string result = _generator.Generate(475);
            Assert.AreEqual("CDLXXV", result);
        }

        [Test]
        public void Translate_500_D()
        {
            string result = _generator.Generate(500);
            Assert.AreEqual("D", result);
        }

        [Test]
        public void Translate_545_DXLV()
        {
            string result = _generator.Generate(545);
            Assert.AreEqual("DXLV", result);
        }

        [Test]
        public void Translate_550_DL()
        {
            string result = _generator.Generate(550);
            Assert.AreEqual("DL", result);
        }

        [Test]
        public void Translate_575_DLXXV()
        {
            string result = _generator.Generate(575);
            Assert.AreEqual("DLXXV", result);
        }

        [Test]
        public void Translate_800_DCCC()
        {
            string result = _generator.Generate(800);
            Assert.AreEqual("DCCC", result);
        }

        [Test]
        public void Translate_875_DCCCLXXV()
        {
            string result = _generator.Generate(875);
            Assert.AreEqual("DCCCLXXV", result);
        }

        [Test]
        public void Translate_900_CM()
        {
            string result = _generator.Generate(900);
            Assert.AreEqual("CM", result);
        }

        [Test]
        public void Translate_950_CML()
        {
            string result = _generator.Generate(950);
            Assert.AreEqual("CML", result);
        }

        [Test]
        public void Translate_990_CMXC()
        {
            string result = _generator.Generate(990);
            Assert.AreEqual("CMXC", result);
        }

        [Test]
        public void Translate_999_CMXCIX()
        {
            string result = _generator.Generate(999);
            Assert.AreEqual("CMXCIX", result);
        }

        [Test]
        public void Translate_1000_M()
        {
            string result = _generator.Generate(1000);
            Assert.AreEqual("M", result);
        }

        [Test]
        public void Translate_2500_MMD()
        {
            string result = _generator.Generate(2500);
            Assert.AreEqual("MMD", result);
        }

        [Test]
        public void Translate_2889_MMDCCCLXXXIX()
        {
            string result = _generator.Generate(2889);
            Assert.AreEqual("MMDCCCLXXXIX", result);
        }

        [Test]
        public void Translate_3999_MMMCMXCIX()
        {
            string result = _generator.Generate(3999);
            Assert.AreEqual("MMMCMXCIX", result);
        }
    }
}
