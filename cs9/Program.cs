namespace cs9
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Choose number of task(1-3): ");
                int.TryParse(Console.ReadLine(), out int task);
                switch (task) 
                {
                    case 1:
                        Fraction fraction1 = new Fraction(2, 3);
                        Fraction fraction2 = new Fraction(1, 7);

                        Console.WriteLine($"Fraction 1: {fraction1}");
                        Console.WriteLine($"Fraction 2: {fraction2}");

                        Fraction sum = fraction1.Addition(fraction2);
                        Console.WriteLine($"Sum: {sum}");

                        Fraction difference = fraction1.Subtraction(fraction2);
                        Console.WriteLine($"Difference: {difference}");

                        Fraction product = fraction1.Multiplication(fraction2);
                        Console.WriteLine($"Product: {product}");

                        Fraction quotient = fraction1.Division(fraction2);
                        Console.WriteLine($"Quotient: {quotient}");
                        break;
                    case 2:
                        ComplexNumber num1 = new ComplexNumber(3, 2);
                        ComplexNumber num2 = new ComplexNumber(4, -2);
                        Console.WriteLine($"Complex Number 1: {num1}");
                        Console.WriteLine($"Complex Number 2: {num2}");

                        ComplexNumber sum2 = num1.Addition(num2);
                        Console.WriteLine($"Sum: {sum2}");

                        ComplexNumber difference2 = num1.Subtraction(num2);
                        Console.WriteLine($"Difference: {difference2}");

                        ComplexNumber product2 = num1.Multiplication(num2);
                        Console.WriteLine($"Product: {product2}");

                        ComplexNumber quotient2 = num1.Division(num2);
                        Console.WriteLine($"Quotient: {quotient2}");
                        break;
                    case 3:
                        Birthday birthday = new Birthday(2007, 8, 15);
                        Console.WriteLine(birthday.ToString());
                        Console.WriteLine($"Day of birth: {birthday.DayOfBirth()}");
                        Console.WriteLine($"Day of the week of birthday in 2025: {birthday.DayOfWeekInYear(2025)}");
                        Console.WriteLine($"Days until birthday: {birthday.DaysUntilBirthday()}");
                        break;
                }
                if (task == 0) break;
            }
        }
    }

    //class User
    //{
    //    public string Name { get; set; }
    //    public string Email { get; set; }
    //    public int Age { get; set; }
    //    public DayOfWeek DayOfWeek { get; set; }
    //}

    //public enum DayOfWeek
    //{
    //    Monday,
    //    Tuesday,
    //    Wednesday,
    //    Thursday,
    //    Friday,
    //    Saturday,
    //    Sunday
    //}

    //struct Point
    //{
    //    public int X { get; }
    //    public int Y { get; }
        
    //    public Point(int x, int y)
    //    {
    //        X = x;
    //        Y = y;
    //    }
    //    public override string ToString() => $"{X} {Y}";
    //}
    //var point = new Point();
    //Console.WriteLine(point.ToString());

    //var today = DayOfWeek.Sunday;
    //Console.WriteLine(today);

    //var user = new User()
    //{ 
    //    Name = "Andrew",
    //    Email = "test@gmail.com",
    //    Age = 25,
    //    DayOfWeek = DayOfWeek.Sunday            
    //};
    //if (user.DayOfWeek == DayOfWeek.Sunday)
    //{
    //    Console.WriteLine(user.Name);
    //}
}
