using System.Numerics;
using FFCalcBusinessLogic;
using FFCalcUserInterfaceLogic.Wrappers;

namespace FiniteFieldCalculator
{
    //!!! re-add something to prevent the use of non-prime finite field

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Wire up the event handler for the TextChanged event of txtPrime
            txtPrime.TextChanged += TxtPrime_TextChanged;

            // Disable other input fields initially
            txtOp1.Enabled = false;
            txtOp2.Enabled = false;
        }

        private void TxtPrime_TextChanged(object sender, EventArgs e)
        {
            // Call a method to check primality when the text in txtPrime changes

            CheckPrimeValidity();
        }

        private void CheckPrimeValidity()
        {
            string input = txtPrime.Text;
            if (BigInteger.TryParse(input, out BigInteger number))
            {
                bool isPrime = ValidationMethods.IsPrime(number);
                txtPrime.BackColor = isPrime ? Color.LightGreen : Color.LightCoral;

                // Enable other input fields based on primality
                txtOp1.Enabled = isPrime;
                txtOp2.Enabled = isPrime;
            }
            else
            {
                txtPrime.BackColor = SystemColors.Window;
            }
        }


        public void ProcessInput(string input)
        {
            if (BigInteger.TryParse(input, out BigInteger bigIntNum))
            {
                Console.WriteLine($"{bigIntNum} converted from string data type to BigInteger data type.");
                // HandleSuccessfulConversion(bigIntNum);// !!! probably going to remove the Enter Prime button - either the calculator buttons are going to check for primality, or I might switch the text box such that primality is tested automatically upon input
            }
            else
            {
                MessageBox.Show("Input error. Please enter an integer.");
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
        private bool textToBigInteger(TextBox textBox, string fieldName, out BigInteger value)
        {
            if (BigInteger.TryParse(textBox.Text, out value))
            {
                return true;
            }
            else
            {
                MessageBox.Show($"Invalid input in {fieldName} field.");
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

        public void btnAdd_Click(object sender, EventArgs e)
        {
            bool success = true;

            // convert input number strings to integers
            success &= textToBigInteger(txtOp1, "Operand A", out BigInteger intValue1);
            success &= textToBigInteger(txtOp2, "Operand B", out BigInteger intValue2);
            success &= textToBigInteger(txtPrime, "Prime", out BigInteger inputPrime);

            if (success)
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

        public void btnSubtract_Click(object sender, EventArgs e)
        {
            bool success = true;

            // convert input number strings to integers
            success &= textToBigInteger(txtOp1, "Operand A", out BigInteger intValue1);
            success &= textToBigInteger(txtOp2, "Operand B", out BigInteger intValue2);
            success &= textToBigInteger(txtPrime, "Prime", out BigInteger inputPrime);

            if (success)
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

        public void btnMulti_Click(object sender, EventArgs e)
        {
            bool success = true;

            // convert input number strings to integers
            success &= textToBigInteger(txtOp1, "Operand A", out BigInteger intValue1);
            success &= textToBigInteger(txtOp2, "Operand B", out BigInteger intValue2);
            success &= textToBigInteger(txtPrime, "Prime", out BigInteger inputPrime);

            if (success)
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

        public void btnDiv_Click(object sender, EventArgs e)
        {
            bool success = true;

            // convert input number strings to integers
            success &= textToBigInteger(txtOp1, "Operand A", out BigInteger intValue1);
            success &= textToBigInteger(txtOp2, "Operand B", out BigInteger intValue2);
            success &= textToBigInteger(txtPrime, "Prime", out BigInteger inputPrime);

            if (success)
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

        public void btnExponent_Click(object sender, EventArgs e)
        {
            bool success = true;

            // convert input number strings to integers
            success &= textToBigInteger(txtOp1, "Operand A", out BigInteger intValue1);
            success &= textToBigInteger(txtExpo, "Exponent", out BigInteger intValue2);
            success &= textToBigInteger(txtPrime, "Prime", out BigInteger inputPrime);

            if (success)
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

        private IMessageBoxWrapper _messageBoxWrapper;

        // Property to set the IMessageBoxWrapper instance
        public IMessageBoxWrapper MessageBoxWrapper
        {
            get => _messageBoxWrapper ?? new MessageBoxWrapper(); // Default to a real MessageBoxWrapper if not set
            set => _messageBoxWrapper = value;
        }

    }
}