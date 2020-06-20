using System;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your equation:");
            string eq;
            eq = Console.ReadLine();
            Mastermind.OperationBuffer(eq);

        }
    }
}