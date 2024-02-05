using System.Numerics;

namespace FFCalcBusinessLogic
{
        public class FFCalc : IFiniteFieldCalculator
        {

            // Addition in the finite field
            public BigInteger Add(BigInteger operand1, BigInteger operand2, BigInteger primeNum)
            {
                BigInteger result = (operand1 + operand2) % primeNum;
                return result;
            }

            // Subtraction in the finite field
            public BigInteger Subtract(BigInteger operand1, BigInteger operand2, BigInteger primeNum)
            {
                BigInteger result = (operand1 - operand2 + primeNum) % primeNum;
                return result;
            }

            // Multiplication in the finite field
            public BigInteger Multiply(BigInteger operand1, BigInteger operand2, BigInteger primeNum)
            {
                BigInteger result = (operand1 * operand2) % primeNum;
                return result;
            }

            // Division in the finite field
            public BigInteger Divide(BigInteger dividend, BigInteger divisor, BigInteger primeNum)
            {
                // Ensure the divisor is not zero
                if (divisor == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero in the finite field.");
                }

                // Calculate the modular inverse of the divisor
                BigInteger inverse = BigInteger.ModPow(divisor, primeNum - 2, primeNum);

                // Multiply the dividend by the inverse of the divisor
                BigInteger result = (dividend * inverse) % primeNum;
                return result;
            }

            // Exponentiation in the finite field
            public BigInteger Exponentiate(BigInteger baseNum, BigInteger exponent, BigInteger primeNum)
            {
                BigInteger result = BigInteger.ModPow(baseNum, exponent, primeNum);
                return result;
            }

            // call operand validation
            public bool ValidOperand(BigInteger operand, BigInteger primeNum)
            {
                // Call the ValidOperand method from ValidationMethods
                return ValidationMethods.IsValidOperand(operand, primeNum);
            }
    }
}
