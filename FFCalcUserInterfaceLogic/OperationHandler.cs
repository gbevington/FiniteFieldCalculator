using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FFCalcBusinessLogic;

namespace FFCalcBusinessLogic
{
    public class OperationHandler
    {
        private readonly IFiniteFieldCalculator _finiteFieldCalculator;

        public OperationHandler(IFiniteFieldCalculator finiteFieldCalculator)
        {
            _finiteFieldCalculator = finiteFieldCalculator;
        }

        public void PerformAddition(BigInteger a, BigInteger b, BigInteger prime, TextBox txtResult)
        {
            PerformOperation((x, y, z) => _finiteFieldCalculator.Add(x, y, z), a, b, prime, txtResult);
        }

        public void PerformSubtraction(BigInteger a, BigInteger b, BigInteger prime, TextBox txtResult)
        {
            PerformOperation((x, y, z) => _finiteFieldCalculator.Subtract(x, y, z), a, b, prime, txtResult);
        }

        public void PerformMultiplication(BigInteger a, BigInteger b, BigInteger prime, TextBox txtResult)
        {
            PerformOperation((x, y, z) => _finiteFieldCalculator.Multiply(x, y, z), a, b, prime, txtResult);
        }

        public void PerformDivision(BigInteger a, BigInteger b, BigInteger prime, TextBox txtResult)
        {
            PerformOperation((x, y, z) => _finiteFieldCalculator.Divide(x, y, z), a, b, prime, txtResult);
        }

        public void PerformExponentiation(BigInteger a, BigInteger b, BigInteger prime, TextBox txtResult)
        {
            PerformOperation((x, y, z) => _finiteFieldCalculator.Exponentiate(x, y, z), a, b, prime, txtResult);
        }

        private void PerformOperation(Func<BigInteger, BigInteger, BigInteger, BigInteger> operation,
            BigInteger a, BigInteger b, BigInteger prime, TextBox txtResult)
        {
            // Check validity of operands against prime number
            if (_finiteFieldCalculator.ValidOperand(a, prime) &&
                _finiteFieldCalculator.ValidOperand(b, prime))
            {
                // Perform calculation using the selected operation
                BigInteger result = operation(a, b, prime);
                txtResult.Text = result.ToString();
            }
        }
    }
}