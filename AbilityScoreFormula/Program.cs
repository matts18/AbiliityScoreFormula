using System;

namespace AbilityScoreFormula
{
    class Program
    {
        static void Main(string[] args)
        {
            AbilityScoreCalculator calculator = new AbilityScoreCalculator();

            while(true)
            {
                calculator.RollResult = ReadInt(calculator.RollResult, "Staring 4d6 roll");
                calculator.DivideBy = ReadDouble(calculator.DivideBy, "Divide by");
                calculator.AddAmount = ReadInt(calculator.AddAmount, "Add amount");
                calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");

                calculator.CalculateAbilityScore();

                Console.WriteLine($"Calculated ability score: {calculator.Score}");
                Console.WriteLine($"Press Q to quit, any other key to continue");

                char keyChar = Console.ReadKey(true).KeyChar;
                if (keyChar == 'q' || keyChar == 'Q') return;
            }
        }


        /// <summary>
        /// Writes a prompt and reads an int value from the console.
        /// </summary>
        /// <param name="lastUsedValue">The default value.</param>
        /// <param name="prompt">Prompt to print to the console.</param>
        /// <returns></returns>
        private static int ReadInt(int lastUsedValue, string prompt)
        {
            Console.Write($"{prompt} default value [{lastUsedValue}]: ");
            string line = Console.ReadLine();
            if(int.TryParse(line, out int result))
            {
                Console.WriteLine($"Using value: {result}");
                return result;
            }
            else
            {
                Console.WriteLine($"Using default value [{lastUsedValue}]: ");
                return lastUsedValue;
            }

        }

        private static double ReadDouble(double lastUsedValue, string prompt)
        {
            Console.Write($"{prompt} default value [{lastUsedValue}]: ");
            string line = Console.ReadLine();
            if (double.TryParse(line, out double result))
            {
                Console.WriteLine($"Using value: {result}");
                return result;
            }
            else
            {
                Console.WriteLine($"Using default value [{lastUsedValue}]: ");
                return lastUsedValue;
            }
        }
    }
}
