using System.Numerics;

namespace FFCalcBusinessLogic
{
    public interface IFiniteFieldCalculator
    {
        BigInteger Add(BigInteger operand1, BigInteger operand2, BigInteger primeNum);
        BigInteger Subtract(BigInteger operand1, BigInteger operand2, BigInteger primeNum);
        BigInteger Multiply(BigInteger operand1, BigInteger operand2, BigInteger primeNum);
        BigInteger Divide(BigInteger dividend, BigInteger divisor, BigInteger primeNum);
        BigInteger Exponentiate(BigInteger baseNum, BigInteger exponent, BigInteger primeNum);
        bool ValidOperand(BigInteger operand, BigInteger primeNum);
    }
}
