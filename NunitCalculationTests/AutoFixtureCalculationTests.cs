using NUnit.Framework;
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
    }
}