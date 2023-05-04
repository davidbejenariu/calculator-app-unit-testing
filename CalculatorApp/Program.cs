using CalculatorApp.OperationHandlers;
using System;
using System.Reflection.Emit;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator app!");
            Console.WriteLine();
            Console.WriteLine("We currently support the following operations:");

            Console.WriteLine("1. Addition of two numbers");
            Console.WriteLine("2. Subtraction of two numbers");
            Console.WriteLine("3. Multiplying two numbers");
            Console.WriteLine("4. Division of two numbers");
            Console.WriteLine("5. Quadratic equation solver");
            Console.WriteLine("6. Matrix addition");
            Console.WriteLine("7. Matrix subtraction");
            Console.WriteLine("8. Matrix multiplication");

            bool running = true;

            while (running)
            {
                bool operationCodeValid = false;
                int opCode = -1;

                while (!operationCodeValid)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter the code of the operation you want to use:");
                    string input = Console.ReadLine();

                    if (input == "quit")
                    {
                        running = false;
                        break;
                    }

                    if (Int32.TryParse(input, out int code))
                    {
                        operationCodeValid = true;
                        opCode = code;
                    }
                    else
                    {
                        Console.WriteLine("Operation code could not be parsed!");
                    }
                }

                if (running == false)
                    break;

                if (opCode == 1)
                {
                    AdditionHandler.Handle();
                    continue;
                }

                if (opCode == 2)
                {
                    SubtractionHandler.Handle();
                    continue;
                }

                if (opCode == 3)
                {
                    MultiplicationHandler.Handle();
                    continue;
                }

                if (opCode == 4)
                {
                    DivisionHandler.Handle();
                    continue;
                }

                if (opCode == 5)
                {
                    QuadraticEquationHandler.Handle();
                }

            }
        }
    }
}
