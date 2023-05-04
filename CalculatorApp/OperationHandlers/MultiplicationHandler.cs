using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.OperationHandlers
{
    public class MultiplicationHandler
    {
        public static void Handle()
        {
            bool numbersParsed = false;
            float A = -1, B = -1;

            while (!numbersParsed)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter the numbers you want to multiply, separated by one space:");
                string input = Console.ReadLine();

                string[] inputSplit = input.Split(" ");

                if (inputSplit.Length != 2)
                {
                    Console.WriteLine("Numbers could not be parsed!");
                    continue;
                }

                if (Single.TryParse(inputSplit[0], NumberStyles.Float, CultureInfo.InvariantCulture, out A)) { }
                else
                {
                    Console.WriteLine("Numbers could not be parsed!");
                    continue;
                }

                if (Single.TryParse(inputSplit[1], NumberStyles.Float, CultureInfo.InvariantCulture, out B)) { }
                else
                {
                    Console.WriteLine("Numbers could not be parsed!");
                    continue;
                }

                numbersParsed = true;
            }

            Calculator<float> calculator = new Calculator<float>();

            float result = calculator.Multiply(A, B);

            Console.WriteLine("The result is: " + result.ToString(CultureInfo.InvariantCulture));
        }
    }
}
