using System;

namespace FibonacciNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitProgram = false;
            while (!exitProgram)
            {
                int indexFibonacciNumber = default;
                int NFibonacciNumber;
                Console.Write("Enter index Fibonacci Numbers: ");
                string enterValye = Console.ReadLine();
                try
                {
                    indexFibonacciNumber = Convert.ToInt32(enterValye);
                    if (indexFibonacciNumber < 1) throw new FormatException();
                    NFibonacciNumber = CalculateNFibonacciNumber(indexFibonacciNumber);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Incorrect value entered");
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("This value is too large");
                    continue;
                }
                Console.WriteLine($"Fibonacci Number by index{indexFibonacciNumber}:" +
                    $" {NFibonacciNumber}");

                Console.WriteLine("Continue the program?");
                if (Console.ReadLine() == "yes") continue;
                else break;
            }
        }

        static int CalculateNFibonacciNumber(int n)
        {
            int FibonacciNumber = 0;
            int nextFibonacciNumber = 1;
            for (int i = 0; i < n - 1; i++)
            {
                if (Convert.ToUInt32(nextFibonacciNumber) + (uint)FibonacciNumber > uint.MaxValue)
                    throw new OverflowException();
                nextFibonacciNumber += FibonacciNumber;
                FibonacciNumber = nextFibonacciNumber - FibonacciNumber;
            }
            return FibonacciNumber;
        }
    }
}
