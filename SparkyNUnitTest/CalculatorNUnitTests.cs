using NUnit.Framework;

namespace Sparky
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        [Test]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            // Arrange
            Calculator calc = new();

            // Act
            int result = calc.AddNumbers(10, 20);

            // Assert
            Assert.That(30, Is.EqualTo(result));
        }
        
        [Test]
        public void IsOddNumber_InputEvenInt_GetFalse()
        {
            // Arange
            Calculator calc = new();

            // Act
            bool result = calc.IsOddNumber(8);

            // Assert
            Assert.That(result, Is.False);
            //Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        [TestCase(-1)]
        [TestCase(1)]
        [TestCase(11)]
        public void IsOddNumber_InputOddInt_GetTrue(int value)
        {
            // Arange
            Calculator calc = new();

            // Act
            bool result = calc.IsOddNumber(value);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(-1, ExpectedResult = true)]
        [TestCase(0, ExpectedResult = false)]
        [TestCase(1, ExpectedResult = true)]
        [TestCase(2, ExpectedResult = false)]
        public bool IsOddNumber_InputNumber_ReturnTrueIfOdd(int value)
        {
            // Arrange done by [TestCase]s
            // Act
            Calculator calc = new();

            // Assert
            return calc.IsOddNumber(value);
        }

        [Test]
        [TestCase(5.4, 10.5)] // 15.9
        [TestCase(5.43, 10.53)] // 15.93
        [TestCase(5.49, 10.59)] // 16.08
        public void AddNumbersDouble_InputTwoDouble_GetCorrectAddition(double a, double b)
        {
            // Arrange
            Calculator calc = new();

            // Act
            double result = calc.AddNumbersDouble(a, b);

            // Assert -- Tolerance of .1
            Assert.That(result, Is.EqualTo(16).Within(.1));
        }
    }
}
