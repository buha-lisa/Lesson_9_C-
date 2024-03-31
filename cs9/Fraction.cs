namespace cs9
{
    struct Fraction
    {
        public int Numerator {  get; }
        public int Denominator { get; }
        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                Console.Write("Cannot divide by zero.\nEnter new denominator: ");
                int.TryParse(Console.ReadLine(), out denominator);
            }
            Numerator = numerator;
            Denominator = denominator;
        }

        public Fraction Addition(Fraction frac1)
        {
            int numerator = frac1.Numerator * Denominator + Numerator * frac1.Denominator;
            int denominator = frac1.Denominator * Denominator;
            return new Fraction(numerator, denominator);
        }
        public Fraction Subtraction(Fraction frac1)
        {
            int numerator = frac1.Numerator * Denominator - Numerator * frac1.Denominator;
            int denominator = frac1.Denominator * Denominator;
            return new Fraction(numerator, denominator);
        }
        public Fraction Multiplication(Fraction frac1)
        {
            int numerator = frac1.Numerator * Numerator;
            int denominator = frac1.Denominator * Denominator;
            return new Fraction(numerator, denominator);
        }
        public Fraction Division(Fraction frac1)
        {
            if (frac1.Numerator == 0)
            {
                Console.WriteLine("Cannot divide by zero.");   
            }

            int numerator = frac1.Numerator * Denominator;
            int denominator = frac1.Denominator * Numerator;
            return new Fraction(numerator, denominator);
        }
        public override string ToString() => $"{Numerator}/{Denominator}";
    }
}
