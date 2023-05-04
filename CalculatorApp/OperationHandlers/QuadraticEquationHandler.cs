using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.OperationHandlers
{
    public class QuadraticEquationHandler
    {
        public static void Handle()
        {
            bool numbersParsed = false;
            float A = -1, B = -1, C = -1;

            while (!numbersParsed)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter the quadratic equation coefficients, separated by one space:");
                string input = Console.ReadLine();

                string[] inputSplit = input.Split(" ");

                if (inputSplit.Length != 3)
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

                if (Single.TryParse(inputSplit[2], NumberStyles.Float, CultureInfo.InvariantCulture, out C)) { }
                else
                {
                    Console.WriteLine("Numbers could not be parsed!");
                    continue;
                }

                numbersParsed = true;
            }

            Calculator<float> calculator = new Calculator<float>();

            float resultA = -1, resultB = -1;
            bool noResult = false;
            
            try
            {
                (resultA, resultB) = calculator.QuadraticEquationSolver(A, B, C);
            }
            catch(Exception e)
            {
                //Console.WriteLine(e.ToString());
                Console.WriteLine("The equation has no real solution");
                noResult = true;
            }
            
            if(!noResult)
            {
                if(resultA == resultB) 
                    Console.WriteLine("The equation has one real solution: " + resultA.ToString(CultureInfo.InvariantCulture));
                else
                    Console.WriteLine("The equation has two real solutions: " + resultA.ToString(CultureInfo.InvariantCulture) + " and " + resultB.ToString(CultureInfo.InvariantCulture));
            }
        }
    }
}
