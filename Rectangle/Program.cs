using ConsoleApp15;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect1 = new Rectangle();
        Rectangle rect2 = new Rectangle();
        rect1.width = 10;
        rect1.height = 10;
        rect2.width = 10;
        rect2.height = 15;
        Console.WriteLine($"Треугольник 1 : Высота {rect1.height} , ширина {rect1.width}, площадь {rect1.GetArea()}, периметр {rect1.GetPerimeter()}");
        Console.WriteLine($"Треугольник 1 : Высота {rect2.height} , ширина {rect2.width}, площадь {rect2.GetArea()}, периметр {rect2.GetPerimeter()}");
    }
}