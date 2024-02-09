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
        // Miller-Rabin primality test
        public static bool IsProbablePrime(BigInteger n, int certainty)
        {
            if (n <= 1)
                return false;

            if (n == 2 || n == 3)
                return true;

            if (n % 2 == 0)
                return false;

            BigInteger d = n - 1;
            int s = 0;
            while (d % 2 == 0)
            {
                d /= 2;
                s += 1;
            }

            Random rand = new Random();
            byte[] bytes = new byte[n.ToByteArray().LongLength];
            BigInteger a;
            for (int i = 0; i < certainty; i++)
            {
                do
                {
                    rand.NextBytes(bytes);
                    a = new BigInteger(bytes);
                }
                while (a < 2 || a >= n - 2);

                BigInteger x = BigInteger.ModPow(a, d, n);
                if (x == 1 || x == n - 1)
                    continue;

                for (int r = 1; r < s; r++)
                {
                    x = BigInteger.ModPow(x, 2, n);
                    if (x == 1)
                        return false;
                    if (x == n - 1)
                        break;
                }

                if (x != n - 1)
                    return false;
            }

            return true;
        }

        // Method to check if a BigInteger is prime
        public static bool IsPrime(BigInteger number)
        {
            return IsProbablePrime(number, 5); // Adjust certainty as needed
        }

        // Method to validate operand
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