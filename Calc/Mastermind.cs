using System;
using System.Globalization;

namespace Calc
{
    public class Mastermind
    {
        public static void OperationBuffer(string var)
        {
            string[] parts = var.Split(' ');

            switch (parts[1])
            {
                case "+":   
                    Console.WriteLine(MathOperations.Sum(float.Parse(parts[0]), float.Parse(parts[2])));
                    break;
                case "-":   
                    Console.WriteLine(MathOperations.Substraction(float.Parse(parts[0]), float.Parse(parts[2])));
                    break;
                case "/":   
                    Console.WriteLine(MathOperations.Division(float.Parse(parts[0]), float.Parse(parts[2])));
                    break;
                case "*":   
                    Console.WriteLine(MathOperations.Multiply(float.Parse(parts[0]), float.Parse(parts[2])));
                    break;
            }
        }
    }
}