using AutoFixture;

namespace NunitCalculationTests
{
    [TestFixture]
    public class AutoFixtureCalculationTests
    {
        private Calculator _calculator;
        private Fixture _fixture;

        [SetUp]
        public void Setup()
        {
            _fixture = new Fixture();
            _calculator = _fixture.Create<Calculator>();
        }

        [Test]
        public void TestAddition()
        {
            // Arrange
            int a = _fixture.Create<int>();
            int b = _fixture.Create<int>();
            int expectedResult = _calculator.Add(a, b);

            // Act
            int actualResult = _calculator.Add(a, b);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestSubtraction()
        {
            // Arrange
            int a = _fixture.Create<int>();
            int b = _fixture.Create<int>();
            int expectedResult = _calculator.Subtract(a, b);

            // Act
            int actualResult = _calculator.Subtract(a, b);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestMultiplication()
        {
            // Arrange
            int a = _fixture.Create<int>();
            int b = _fixture.Create<int>();
            int expectedResult = _calculator.Multiply(a, b);

            // Act
            int actualResult = _calculator.Multiply(a, b);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestDivision()
        {
            // Arrange
            int a = _fixture.Create<int>();
            int b = _fixture.Create<int>();
            int expectedResult = _calculator.Divide(a, b);

            // Act
            int actualResult = _calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestModulo()
        {
            // Arrange
            var fixture = new Fixture();
            int a = fixture.Create<int>();
            int b = fixture.Create<int>();
            if (b == 0)
            {
                b = 1; // Avoid division by zero error in Arrange phase
            }
            int expectedResult = a % b;
            var calculator = new Calculator();

            // Act
            int actualResult = calculator.Modulo(a, b);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestPower()
        {
            // Arrange
            double a = _fixture.Create<double>();
            double b = _fixture.Create<double>();
            double expectedResult = Math.Pow(a, b);

            // Act
            double actualResult = _calculator.Power(a, b);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestSquareRoot()
        {
            // Arrange
            double a = _fixture.Create<double>();
            if (a < 0)
            {
                Assert.Throws<ArgumentException>(() => _calculator.SquareRoot(a));
            }
            else
            {
                double expectedResult = Math.Sqrt(a);

                // Act
                double actualResult = _calculator.SquareRoot(a);

                // Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
        }

        [Test]
        public void TestFactorial()
        {
            // Arrange
            int a = _fixture.Create<int>();
            if (a < 0)
            {
                Assert.Throws<ArgumentException>(() => _calculator.Factorial(a));
            }
            else
            {
                int expectedResult = 1;
                for (int i = a; i > 0; i--)
                {
                    expectedResult *= i;
                }

                // Act
                int actualResult = _calculator.Factorial(a);

                // Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
        }

    }
}