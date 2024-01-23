using NUnit.Framework;
using FiniteFieldCalculator;
using Moq;
using System.Windows.Forms;


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
        public void NameOfMethod()
        {
            // Arrange

            // Act

            // Assert
        }

    }
}
