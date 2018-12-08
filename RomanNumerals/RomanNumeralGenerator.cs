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
                int fraction = number / 10;

                if (fraction == 1)
                {
                    romanNumerals.Append("X");
                }
                else
                {
                    romanNumerals.Append('X', fraction);
                }
            }

            romanNumerals.Append(GetUnitNumeral(number));

            return romanNumerals.ToString();
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
