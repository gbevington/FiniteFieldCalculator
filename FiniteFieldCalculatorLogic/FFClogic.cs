using System.Numerics;

namespace FFCalcBusinessLogic
{
    public interface IFiniteFieldCalculator
   {
    bool isPrime(int num);
    bool ValidOperand(BigInteger operand, BigInteger primeNum);
    BigInteger Add(BigInteger a, BigInteger b, BigInteger prime);
    BigInteger Subtract(BigInteger a, BigInteger b, BigInteger prime);
    BigInteger Multiply(BigInteger a, BigInteger b, BigInteger prime);
    BigInteger Divide(BigInteger a, BigInteger b, BigInteger prime);
    BigInteger Exponentiate(BigInteger baseValue, BigInteger exponent, BigInteger prime);
}
    public class FiniteFieldCalculator : IFiniteFieldCalculator
    {

        public bool isPrime(int num)
        {
            if (num <= 1)
            {
                Console.WriteLine($"{num} is not prime (less than or equal to 1).");

                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++) // check up to square root of num for factors
            {
                if (num % i == 0)
                {
                    Console.WriteLine($"{num} is not prime. Divisible by {i}.");

                    return false;
                }
            }

            Console.WriteLine($"{num} is prime.");
            return true;    // num is prime
        }

        public bool ValidOperand(BigInteger operand, BigInteger primeNum)
        {
            return operand >= 0 && operand < primeNum;
        }

        public BigInteger Add(BigInteger a, BigInteger b, BigInteger prime)
        {
            BigInteger result = (a + b) % prime;
            return result;
        }

        public BigInteger Subtract(BigInteger a, BigInteger b, BigInteger prime)
        {
            BigInteger result = ((((a - b) % prime) + prime) % prime);
            return result;
        }

        public BigInteger Multiply(BigInteger a, BigInteger b, BigInteger prime)
        {
            BigInteger result = (a * b) % prime;
            return result;
        }

        public BigInteger Divide(BigInteger a, BigInteger b, BigInteger prime)
        {
            BigInteger result = (BigInteger.Divide(a, b) % prime);
            return result;
        }

        public BigInteger Exponentiate(BigInteger baseValue, BigInteger exponent, BigInteger prime)
        {
            BigInteger result = BigInteger.ModPow(baseValue, exponent, prime);
            return result;
        }

        //!!! add comments
    }
}
