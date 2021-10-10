using System;

namespace Lesson8Task1
{


//    Задание
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте метод с именем Calculate, который принимает в качестве параметров три целочисленных
//значения и возвращает значение каждого аргумента деленного на 5.

    class Program
    {

        static double a;
        static double b;
        static double c;

        static void Calculate(int x, int y, int z)
        {
            a = (double)x / 5;
            b = (double)y / 5;
            c = (double)z / 5;
            Console.WriteLine($"{a} | {b} | {c}");
        }

        static void Main(string[] args)
        {
            Calculate(3, 4, 1);
        }
    }
}
