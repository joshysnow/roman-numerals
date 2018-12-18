using System;
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
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("number", "Must be greater than or equal to 0");
            }

            StringBuilder romanNumerals = new StringBuilder();

            // 1000's
            SetThousandsNumeral(romanNumerals, ref number);

            // 100's
            SetNumerals(romanNumerals, ref number, 100, 'C', 'D', 'M');

            // 10's
            SetNumerals(romanNumerals, ref number, 10, 'X', 'L', 'C');

            // 1's
            SetUnitNumeral(romanNumerals, number);

            return romanNumerals.ToString();
        }

        /// <summary>
        /// Thousands only adds the required number of M letters. So
        /// this method only divises the fraction and adds the appropriate
        /// number of Ms.
        /// </summary>
        /// <param name="numerals">Current numerals</param>
        /// <param name="number">Number to convert</param>
        private void SetThousandsNumeral(StringBuilder numerals, ref int number)
        {
            if (number < 1000)
                return;

            int fraction = number / 1000;
            number -= fraction * 1000;

            numerals.Append('M', fraction);
        }

        /// <summary>
        /// A general function for 10s and 100s as the logic is identical. Same would
        /// be true for thousands if it had a mid and next order numeral.
        /// Given a number, divise the fraction, apply the pre mid or pre next rule then exit.
        /// Otherwise, test if we're midway and add the midway numeral followed by any 
        /// more numerals to make up the sum of the number.
        /// </summary>
        /// <param name="numerals">Current numerals</param>
        /// <param name="number">Number to convert</param>
        /// <param name="units">Units/order (10s or 100s)</param>
        /// <param name="numeral">Main numeral for this unit i.e. X or C</param>
        /// <param name="midNumeral">Mid point numeral like 50 or 500.</param>
        /// <param name="nextNumeral">Next order numeral i.e. C for 100s after 10s. Used for numerals in the 9s.</param>
        private void SetNumerals(StringBuilder numerals, ref int number, int units, char numeral, char midNumeral, char nextNumeral)
        {
            if (number < units)
                return;

            int fraction = number / units;

            if (fraction == 4)
            {
                // i.e. 40 XL
                numerals.Append(numeral);
                numerals.Append(midNumeral);
            }
            else if (fraction == 9)
            {
                // i.e. 90 XC
                numerals.Append(numeral);
                numerals.Append(nextNumeral);
            }
            else
            {
                if (fraction >= 5)
                {
                    // i.e. L or D
                    numerals.Append(midNumeral);

                    // remove midway units to prevent adding numerals to make the mid numeral
                    number -= 5 * units;
                    fraction = number / units;
                }

                numerals.Append(numeral, fraction);
            }

            // consume the number for the numerals appeneded
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
