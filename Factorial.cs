using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Программа вычисления факториала");
 
        Console.Write("Введите число для вычисления факториала: ");
        string input = Console.ReadLine();
 
        if (!int.TryParse(input, out int number) || number < 0)
        {
            Console.WriteLine("Ошибка: введите положительное целое число");
            return;
        }
        
        long factorial = CalculateFactorial(number);
 
        Console.WriteLine($"Факториал числа {number} равен {factorial}");
  
        Console.ReadKey();
    }
 
    static long CalculateFactorial(int n)
    {
        long result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}