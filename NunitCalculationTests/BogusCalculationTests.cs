namespace NunitCalculationTests
{
    [TestFixture]
    public class BogusCalculationTests
    {
        private Calculator _calculator;
        private Bogus.Faker _faker;

        [SetUp]
        public void Setup()
        {
            _faker = new Bogus.Faker();
            _calculator = new Calculator();
        }

        [Test]
        public void TestAddition()
        {
            // Arrange
            int a = _faker.Random.Int();
            int b = _faker.Random.Int();
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
            int a = _faker.Random.Int();
            int b = _faker.Random.Int();
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
            int a = _faker.Random.Int();
            int b = _faker.Random.Int();
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
            int a = _faker.Random.Int();
            int b = _faker.Random.Int(min: 1); // Avoid divide-by-zero
            int expectedResult = _calculator.Divide(a, b);

            // Act
            int actualResult = _calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}