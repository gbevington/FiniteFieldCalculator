using NUnit.Framework;
using Moq;
using System.Windows.Forms;
using FFCalcUserInterfaceLogic;
using FFCalcUserInterfaceLogic.Wrappers;
using FFCalcBusinessLogic;

namespace FiniteFieldCalculator.Tests
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void IsPrimeTrue()
        {
            // Arrange
            int primeNumber = 7;

            // Act
            bool result = Form1.isPrime(primeNumber);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPrimeNotTrue()
        {
            // Arrange
            int nonPrimeNumber = 10; 

            // Act
            bool result = Form1.isPrime(nonPrimeNumber);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void HandleSuccessfulConversion_WhenPrime_ShouldShowSuccessMessage()
        {
            // Arrange
            var messageBoxWrapperMock = new Mock<IMessageBoxWrapper>();
            var form1 = new Form1();
            form1.MessageBoxWrapper = messageBoxWrapperMock.Object;

            // Act
            form1.HandleSuccessfulConversion(7);

            // Assert
            messageBoxWrapperMock.Verify(m => m.Show("Input successful."), Times.Once);
        }

        [Test]
        public void HandleSuccessfulConversion_InputSuccessful_ShowsSuccessMessage()
        {
            // Arrange
            var form = new Form1();
            var messageBoxMock = new Mock<IMessageBoxWrapper>();
            form.MessageBoxWrapper = messageBoxMock.Object;

            // Act
            form.HandleSuccessfulConversion(5);

            // Assert
            messageBoxMock.Verify(m => m.Show("Input successful."), Times.Once);
        }

        [Test]
        public void BtnAddClick_ValidOperands_CalculatesResult()
        {
            // Arrange
            var form = new Form1();

            // Set up your TextBox values
            form.txtOp1.Text = "5";
            form.txtOp2.Text = "7";
            form.txtPrime.Text = "11";

            // Act
            form.btnAdd_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("1", form.txtResult.Text);
        }

        [Test]
        public void BtnSubtractClick_ValidOperands_CalculatesResult()
        {
            // Arrange
            var form = new Form1();

            // Set up your TextBox values
            form.txtOp1.Text = "10";
            form.txtOp2.Text = "7";
            form.txtPrime.Text = "11";

            // Act
            form.btnSubtract_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("3", form.txtResult.Text);
        }

        [Test]
        public void BtnMultiplyClick_ValidOperands_CalculatesResult()
        {
            // Arrange
            var form = new Form1();

            // Set up your TextBox values
            form.txtOp1.Text = "5";
            form.txtOp2.Text = "7";
            form.txtPrime.Text = "11";

            // Act
            form.btnMulti_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("2", form.txtResult.Text);
        }

        [Test]
        public void BtnDivideClick_ValidOperands_CalculatesResult()
        {
            // Arrange
            var form = new Form1();

            // Set up your TextBox values
            form.txtOp1.Text = "15";
            form.txtOp2.Text = "3";
            form.txtPrime.Text = "11";

            // Act
            form.btnDiv_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("1", form.txtResult.Text);
        }

        [Test]
        public void BtnExponentClick_ValidOperands_CalculatesResult()
        {
            // Arrange
            var form = new Form1();

            // Set up your TextBox values
            form.txtOp1.Text = "2";
            form.txtExpo.Text = "3";
            form.txtPrime.Text = "11";

            // Act
            form.btnExponent_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual("8", form.txtResult.Text);
        }

    }
}
