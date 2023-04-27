using Faker;

namespace NunitCalculationTests
{
    [TestFixture]
    public class FakerDotNetCalculationTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void TestAddition()
        {
            // Arrange
            int a = RandomNumber.Next();
            int b = RandomNumber.Next();
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
            int a = RandomNumber.Next();
            int b = RandomNumber.Next();
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
            int a = RandomNumber.Next();
            int b = RandomNumber.Next();
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
            int a = RandomNumber.Next();
            int b = RandomNumber.Next();
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
            int a = Faker.RandomNumber.Next();
            int b = Faker.RandomNumber.Next(1, 100);
            int expectedResult = _calculator.Modulo(a, b);

            // Act
            int actualResult = _calculator.Modulo(a, b);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestFactorial()
        {
            // Arrange
            int a = Faker.RandomNumber.Next(1, 10);
            int expectedResult = _calculator.Factorial(a);

            // Act
            int actualResult = _calculator.Factorial(a);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}