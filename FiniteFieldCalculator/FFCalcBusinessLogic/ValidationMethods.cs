using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Numerics;

namespace FFCalcBusinessLogic
{
    public static class ValidationMethods
    {
        public static bool IsPrime(int num)
        {
            if (num <= 1)
            {
                Console.WriteLine($"{num} is not prime (less than or equal to 1).");
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine($"{num} is not prime. Divisible by {i}.");
                    return false;
                }
            }

            Console.WriteLine($"{num} is prime.");
            return true;
        }

        public static bool IsValidOperand(BigInteger operand, BigInteger primeNum)
        {
            if (operand >= primeNum || operand < 0)
            {
                Console.WriteLine("Invalid operand. Operand must be between zero and the prime input number minus one.");
                return false;
            }

            return true;
        }
    }
}
