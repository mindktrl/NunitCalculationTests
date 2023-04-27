namespace NunitCalculationTests
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        }

        public int Modulo(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Cannot take modulo by zero.");
            }
            return a % b;
        }

        public double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public double SquareRoot(double a)
        {
            if (a < 0)
            {
                throw new ArgumentException("Cannot take square root of a negative number.");
            }
            return Math.Sqrt(a);
        }

        public int Factorial(int a)
        {
            if (a < 0)
            {
                throw new ArgumentException("Cannot take factorial of a negative number.");
            }
            int result = 1;
            for (int i = a; i > 0; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
