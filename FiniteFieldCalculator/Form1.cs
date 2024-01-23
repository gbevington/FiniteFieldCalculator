using System.Numerics;

namespace FiniteFieldCalculator
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static bool isPrime(int num)
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

        public void btnEnterPrime_Click(object sender, EventArgs e)
        {
            string input = txtPrime.Text;
            ProcessInput(input);
        }

        public void ProcessInput(string input)
        {
            if (int.TryParse(input, out int intNum))
            {
                Console.WriteLine($"{intNum} converted from string data type to int data type.");
                HandleSuccessfulConversion(intNum);
            }
            else
            {
                MessageBox.Show("Input error. Please enter an integer.");
            }
        }

        public void HandleSuccessfulConversion(int intNum)
        {
            if (isPrime(intNum))
            {
                MessageBox.Show("Input successful.");
            }
            else
            {
                MessageBox.Show("Input failed. Please enter a prime number.");
            }
        }

        public void handleSelectedNISTPrime(string prime)
        {
            //update textbox
            txtPrime.Text = prime.ToString();
        }
        private void btnNIST_Click(object sender, EventArgs e)
        {
            //create instance of NIST form
            using (var nistPrimesForm = new NISTPrimesForm())
            {
                //subscribe to the event and call handler in main form
                nistPrimesForm.NISTPrimeSelected += (s, prime) =>
                {
                    handleSelectedNISTPrime(prime.ToString());
                };

                //show NIST form
                nistPrimesForm.ShowDialog();
            }
        }

        // convert text box input to integer
        private bool textToBigInteger(TextBox textBox, out BigInteger value)
        {
            if (BigInteger.TryParse(textBox.Text, out value))
            {
                return true;
            }
            else
            {
                MessageBox.Show($"Invalid input in {textBox.Name}.");
                return false;
            }
        }

        // confirm that operand belongs to the set of elements in our inputs finite field
        static bool validOperand(BigInteger operand, BigInteger primeNum)
        {
            if (operand >= primeNum || operand < 0)
            {
                MessageBox.Show("One of your operands is invalid. Both operands must be between zero and the prime input number minus one.");
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // convert input number strings to integers
            if (textToBigInteger(txtOp1, out BigInteger intValue1) &&
                textToBigInteger(txtOp2, out BigInteger intValue2) &&
                textToBigInteger(txtPrime, out BigInteger inputPrime))
            {
                //check validity of operands against prime number
                if (validOperand(intValue1, inputPrime) && validOperand(intValue2, inputPrime))
                {
                    //perform calculation
                    BigInteger result = ((intValue1 + intValue2) % inputPrime);

                    txtResult.Text = result.ToString();
                }
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            // convert input number strings to integers
            if (textToBigInteger(txtOp1, out BigInteger intValue1) &&
                textToBigInteger(txtOp2, out BigInteger intValue2) &&
                textToBigInteger(txtPrime, out BigInteger inputPrime))
            {
                //check validity of operands against prime number
                if (validOperand(intValue1, inputPrime) && validOperand(intValue2, inputPrime))
                {
                    //perform calculation
                    BigInteger result = ((((intValue1 - intValue2) % inputPrime) + inputPrime) % inputPrime);

                    txtResult.Text = ($"{result}");
                }
            }

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            // convert input number strings to integers
            if (textToBigInteger(txtOp1, out BigInteger intValue1) &&
                textToBigInteger(txtOp2, out BigInteger intValue2) &&
                textToBigInteger(txtPrime, out BigInteger inputPrime))
            {
                //check validity of operands against prime number
                if (validOperand(intValue1, inputPrime) && validOperand(intValue2, inputPrime))
                {
                    //perform calculation
                    BigInteger result = ((intValue1 * intValue2) % inputPrime);
                    txtResult.Text = ($"{result}");
                }
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            // convert input number strings to integers
            if (textToBigInteger(txtOp1, out BigInteger intValue1) && 
                textToBigInteger(txtOp2, out BigInteger intValue2) && 
                textToBigInteger(txtPrime, out BigInteger inputPrime))
            {
                //check validity of operands against prime number
                if (validOperand(intValue1, inputPrime) && validOperand(intValue2, inputPrime))
                {
                    // Perform the calculation for division
                    BigInteger result = (BigInteger.Divide(intValue1, intValue2) % inputPrime);
                    txtResult.Text = result.ToString();
                }

            }
        }

        private void btnExponent_Click(object sender, EventArgs e)
        {
            //convert input number strings to big integers
            if (textToBigInteger(txtOp1, out BigInteger intValue1) && 
                textToBigInteger(txtExpo, out BigInteger intValue2) && 
                textToBigInteger(txtPrime, out BigInteger inputPrime))
            {
                // check operand validity
                if (validOperand(intValue1, inputPrime))
                {
                    //perform calculation for exponentiation
                    BigInteger result = BigInteger.One;

                    for (BigInteger i = 0; i < intValue2; i++)
                    {
                        result *= intValue1;
                    }

                    result %= inputPrime;   // keep result within the finite field

                    txtResult.Text = result.ToString();
                }
            }

        }
        //!!! to do : write unit tests for all methods, README file

    }
}