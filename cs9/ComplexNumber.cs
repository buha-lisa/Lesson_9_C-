namespace cs9
{
    struct ComplexNumber
    {
        public double Real {  get; }
        public double Imaginary { get; }
        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public ComplexNumber Addition(ComplexNumber num1)
        {
            double realPart = num1.Real + Real;
            double imaginaryPart = num1.Imaginary + Imaginary;
            return new ComplexNumber(realPart, imaginaryPart);
        }
        public ComplexNumber Subtraction(ComplexNumber num1)
        {
            double realPart = num1.Real - Real;
            double imaginaryPart = num1.Imaginary - Imaginary;
            return new ComplexNumber(realPart, imaginaryPart);
        }
        public ComplexNumber Multiplication(ComplexNumber num1)
        {
            double realPart = num1.Real * Real - num1.Imaginary * Imaginary;
            double imaginaryPart = num1.Real * Imaginary + Real * num1.Imaginary;
            return new ComplexNumber(realPart, imaginaryPart);
        }
        public ComplexNumber Division(ComplexNumber num1)
        {
            double denominator = Real * Real + Imaginary * Imaginary;
            if (denominator == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
            }

            double realPart = (num1.Real * Real + num1.Imaginary * Imaginary) / denominator;
            double imaginaryPart = (Real * num1.Imaginary - num1.Real * Imaginary) / denominator;
            return new ComplexNumber(realPart, imaginaryPart);
        }

        public override string ToString()
        {
            if (Imaginary >= 0)
            {
                return $"{Real} + {Imaginary}i";
            }
            else
            {
                return $"{Real} - {-Imaginary}i";
            }
        }
    }
}
