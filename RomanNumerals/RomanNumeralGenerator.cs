using System.Text;

namespace RomanNumerals
{
    public class RomanNumeralGenerator : IRomanNumeralGenerator
    {
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
