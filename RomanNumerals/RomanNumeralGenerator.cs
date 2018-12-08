using System.Text;

namespace RomanNumerals
{
    /// <summary>
    /// Converts numbers into roman numeral strings.
    /// </summary>
    public class RomanNumeralGenerator : IRomanNumeralGenerator
    {
        /// <summary>
        /// Given a base10 <paramref name="number"/> return the equivalent
        /// in roman numerals.
        /// </summary>
        /// <returns>Roman numerals for given input</returns>
        /// <param name="number">Base10 number</param>
        public string Generate(int number)
        {
            StringBuilder romanNumerals = new StringBuilder();

            if (number >= 10)
            {
                SetTensNumeral(romanNumerals, ref number);
            }

            romanNumerals.Append(GetUnitNumeral(number));

            return romanNumerals.ToString();
        }

        private void SetTensNumeral(StringBuilder numerals, ref int number)
        {
            int fraction = number / 10;

            if (fraction == 4)
            {
                numerals.Append("XL");
            }
            else if (fraction == 9)
            {
                numerals.Append("XC");
            }
            else
            {
                if (fraction >= 5)
                {
                    numerals.Append("L");
                    number -= 50;
                    fraction = number / 10;
                }

                numerals.Append('X', fraction);
            }

            number -= fraction * 10;
        }

        /// <summary>
        /// Given a number as a unit (1-9) return the
        /// roman numeral equivalent or empty string.
        /// </summary>
        /// <returns>A roman numeral or nothing</returns>
        /// <param name="number">Base10 unit number</param>
        private string GetUnitNumeral(int number)
        {
            switch (number)
            {
                case 1: return "I";
                case 2: return "II";
                case 3: return "III";
                case 4: return "IV";
                case 5: return "V";
                case 6: return "VI";
                case 7: return "VII";
                case 8: return "VIII";
                case 9: return "IX";
                default: return string.Empty;
            }
        }
    }
}
