using System;

namespace RomanNumerals
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Roman Numeral Generator program!\n");
            Console.WriteLine("Enter a base10 number to translate it into Roman numerals!");
            Console.WriteLine("\nEnter Q to quit\n");

            RomanNumeralGenerator generator = new RomanNumeralGenerator();
            string input;
            string output;
            bool end = false;

            do
            {
                Console.Write("Enter: ");
                input = Console.ReadLine();

                if (input.ToLower().Contains("q"))
                    break;

                bool parsed = int.TryParse(input, out int number);

                if (int.TryParse(input, out number))
                {
                    try
                    {
                        output = generator.Generate(number);
                        Console.WriteLine(" = " + output + "\n");
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("Number must be at least 0 or more\n");
                    }
                }
                else
                {
                    Console.WriteLine("\nProblem reading number, please try again...\n");
                }

            } while (!end);

            Console.WriteLine("\nGoodbye!\n");
        }
    }
}
