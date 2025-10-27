using System;

public class Calculator
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Деление на ноль невозможно.");
        }
        return a / b;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        double num1, num2;
        char operation;

        Console.WriteLine("Введите первое число:");
        num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите операцию (+, -, *, /):");
        operation = Console.ReadKey().KeyChar;
        Console.WriteLine();

        Console.WriteLine("Введите второе число:");
        num2 = double.Parse(Console.ReadLine());

        double result = 0;
        try
        {
            switch (operation)
            {
                case '+':
                    result = calc.Add(num1, num2);
                    break;
                case '-':
                    result = calc.Subtract(num1, num2);
                    break;
                case '*':
                    result = calc.Multiply(num1, num2);
                    break;
                case '/':
                    result = calc.Divide(num1, num2);
                    break;
                default:
                    Console.WriteLine("Некорректная операция.");
                    return;
            }
            Console.WriteLine($"Результат: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}