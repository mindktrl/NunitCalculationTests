namespace NunitCalculationTests
{

    [TestFixture]
    public class CalculationTests
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
            int a = 10;
            int b = 5;
            int expectedResult = 15;

            // Act
            int actualResult = _calculator.Add(a, b);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestSubtraction()
        {
            // Arrange
            int a = 10;
            int b = 5;
            int expectedResult = 5;

            // Act
            int actualResult = _calculator.Subtract(a, b);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestMultiplication()
        {
            // Arrange
            int a = 10;
            int b = 5;
            int expectedResult = 50;

            // Act
            int actualResult = _calculator.Multiply(a, b);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestDivision()
        {
            // Arrange
            int a = 10;
            int b = 5;
            int expectedResult = 2;

            // Act
            int actualResult = _calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}