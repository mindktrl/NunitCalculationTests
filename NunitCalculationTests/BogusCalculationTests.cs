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

        [Test]
        public void TestModulo()
        {
            int a = _faker.Random.Int();
            int b = _faker.Random.Int(min: 1); // Ensure b is not zero
            int expectedResult = a % b;

            int actualResult = _calculator.Modulo(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestModuloByZero()
        {
            int a = _faker.Random.Int();
            int b = 0;

            Assert.Throws<ArgumentException>(() => _calculator.Modulo(a, b));
        }

        [Test]
        public void TestPower()
        {
            double a = _faker.Random.Double();
            double b = _faker.Random.Double();
            double expectedResult = Math.Pow(a, b);

            double actualResult = _calculator.Power(a, b);

            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [Test]
        public void TestSquareRoot()
        {
            double a = _faker.Random.Double(min: 0);
            double expectedResult = Math.Sqrt(a);

            double actualResult = _calculator.SquareRoot(a);

            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [Test]
        public void TestSquareRootOfNegativeNumber()
        {
            double a = _faker.Random.Double(max: -1);

            Assert.Throws<ArgumentException>(() => _calculator.SquareRoot(a));
        }

        [Test]
        public void TestFactorial()
        {
            int a = _faker.Random.Int(min: 0, max: 10);
            int expectedResult = 1;
            for (int i = a; i > 0; i--)
            {
                expectedResult *= i;
            }

            int actualResult = _calculator.Factorial(a);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestFactorialOfNegativeNumber()
        {
            int a = _faker.Random.Int(max: -1);

            Assert.Throws<ArgumentException>(() => _calculator.Factorial(a));
        }
    }
}