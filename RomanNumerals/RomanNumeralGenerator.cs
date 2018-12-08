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

            if (number >= 1000)
            {
                SetThousandsNumeral(romanNumerals, ref number);
            }

            if (number >= 100)
            {
                SetNumerals(romanNumerals, ref number, 100, 'C', 'D', 'M');
            }

            if (number >= 10)
            {
                SetNumerals(romanNumerals, ref number, 10, 'X', 'L', 'C');
            }

            SetUnitNumeral(romanNumerals, number);

            return romanNumerals.ToString();
        }

        private void SetThousandsNumeral(StringBuilder numerals, ref int number)
        {
            int fraction = number / 1000;
            number -= fraction * 1000;

            numerals.Append('M', fraction);
        }

        private void SetNumerals(StringBuilder numerals, ref int number, int units, char numeral, char midNumeral, char nextNumeral)
        {
            int fraction = number / units;

            if (fraction == 4)
            {
                numerals.Append(numeral);
                numerals.Append(midNumeral);
            }
            else if (fraction == 9)
            {
                numerals.Append(numeral);
                numerals.Append(nextNumeral);
            }
            else
            {
                if (fraction >= 5)
                {
                    numerals.Append(midNumeral);
                    number -= 5 * units;
                    fraction = number / units;
                }

                numerals.Append(numeral, fraction);
            }

            number -= fraction * units;
        }
    
        /// <summary>
        /// Given a number as a unit(1-9) return the
        /// roman numeral equivalent or empty string.
        /// </summary>
        /// <param name="numerals">Numerals</param>
        /// <param name="number">Base10 unit number</param>
        private void SetUnitNumeral(StringBuilder numerals, int number)
        {
            switch (number)
            {
                case 1: numerals.Append("I");       break;
                case 2: numerals.Append("II");      break;
                case 3: numerals.Append("III");     break;
                case 4: numerals.Append("IV");      break;
                case 5: numerals.Append("V");       break;
                case 6: numerals.Append("VI");      break;
                case 7: numerals.Append("VII");     break;
                case 8: numerals.Append("VIII");    break;
                case 9: numerals.Append("IX");      break;
                default: break;
            }
        }
    }
}
