using System.Numerics;

namespace FiniteFieldCalcLogic
{
    public interface IFiniteFieldCalculator
    {
        bool IsPrime(int num);
        bool TextToBigInteger(string input, out BigInteger value);
        bool ValidOperand(BigInteger operand, BigInteger primeNum);
        BigInteger Add(BigInteger a, BigInteger b, BigInteger prime);
        // ... other methods
    }

    public class FiniteFieldCalculator : IFiniteFieldCalculator
    {
        public bool IsPrime(int num)
        {
            // Implementation
        }

        public bool TextToBigInteger(string input, out BigInteger value)
        {
            // Implementation
        }

        public bool ValidOperand(BigInteger operand, BigInteger primeNum)
        {
            // Implementation
        }

        public BigInteger Add(BigInteger a, BigInteger b, BigInteger prime)
        {
            // Implementation
        }

        // ... other methods
    }
}
