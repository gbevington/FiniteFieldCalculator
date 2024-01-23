using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiniteFieldCalculator
{
    public partial class NISTPrimesForm : Form
    {
        //notify main form
        public event EventHandler<BigInteger> NISTPrimeSelected;
        public NISTPrimesForm()
        {
            InitializeComponent();
        }

        private void btnP192_Click(object sender, EventArgs e)
        {
            // Calculate the result of the expression 2^192 - 2^64 - 1
            BigInteger result = BigInteger.Pow(2, 192) - BigInteger.Pow(2, 64) - BigInteger.One;


            // Notify the main form with the calculated result
            NISTPrimeSelected?.Invoke(this, result);
            Close(); // Close the NISTPrimesForm after selection


        }

        private void btnP224_Click(object sender, EventArgs e)
        {

            // Calculate the result of the expression 2^224 - 2^96 + 1
            BigInteger result = BigInteger.Pow(2, 224) - BigInteger.Pow(2, 96) + BigInteger.One;

            // Notify the main form with the calculated result
            NISTPrimeSelected?.Invoke(this, result);
            Close(); // Close the NISTPrimesForm after selection

        }

        private void btnP256_Click(object sender, EventArgs e)
        {
            // Calculate the result of the expression 2^256 - 2^244 + 2^192 + 2^96 - 1
            BigInteger result = BigInteger.Pow(2, 256) - BigInteger.Pow(2, 244) + BigInteger.Pow(2, 192) + BigInteger.Pow(2, 96) - BigInteger.One;

            // Notify the main form with the calculated result
            NISTPrimeSelected?.Invoke(this, result);
            Close(); // Close the NISTPrimesForm after selection
        }

        private void btnP384_Click(object sender, EventArgs e)
        {
            // Calculate the result of the expression 2^384 - 2^128 - 2^96 + 2^32 - 1
            BigInteger result = BigInteger.Pow(2, 384) - BigInteger.Pow(2, 128) - BigInteger.Pow(2, 96) + BigInteger.Pow(2, 32) - BigInteger.One;

            // Notify the main form with the calculated result
            NISTPrimeSelected?.Invoke(this, result);
            Close(); // Close the NISTPrimesForm after selection
        }

        private void btnP521_Click(object sender, EventArgs e)
        {
            // Calculate the result of the expression 2^521 - 1
            BigInteger result = BigInteger.Pow(2, 521) - BigInteger.One;

            // Notify the main form with the calculated result
            NISTPrimeSelected?.Invoke(this, result);            
            Close(); // Close the NISTPrimesForm after selection
        }


    }
}
