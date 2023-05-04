using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.OperationHandlers
{
    public class AdditionHandler
    {
        public static void Handle()
        {
            bool numbersParsed = false;
            float A = -1, B = -1;

            while (!numbersParsed)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter the numbers you want to add, separated by one or more spaces:");
                string input = Console.ReadLine();

                string[] inputSplit = input.Split(" ");

                if(inputSplit.Length != 2 )
                {
                    Console.WriteLine("Numbers could not be parsed!");
                    continue;
                }

                if(Single.TryParse(inputSplit[0], out A)) { }
                else
                {
                    Console.WriteLine("Numbers could not be parsed!");
                    continue;
                }

                if (Single.TryParse(inputSplit[1], out B)) { }
                else
                {
                    Console.WriteLine("Numbers could not be parsed!");
                    continue;
                }

                numbersParsed = true;
            }

            Calculator<float> calculator = new Calculator<float>();

            float result = calculator.Add(A, B);

            Console.WriteLine("The result is: " + result.ToString());
        }
    }
}
