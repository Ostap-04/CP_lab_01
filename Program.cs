
using System;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Завдання 1");
            Console.WriteLine($"Середнє арифметичне цифр заданого числа = {Task_1()}");

            Console.WriteLine("\nЗавдання 2");
            Console.WriteLine($"max(a, b, c) = {Task_2()}\n\n");

            Console.WriteLine("Завдання 3");
            Task_3();
        }

        static double Task_1() 
        {
            //Task 1
            //1. Дано натуральне число n. Обчислити середнє арифметичне цифр його запису.

            Console.Write("Введіть натуральне число: ");
            uint num = uint.Parse(Console.ReadLine());
            uint numCopy = num;
            uint sum = 0, counter = 0;
            while (numCopy != 0) 
            {
                sum += numCopy % 10;
                numCopy /= 10;
                counter++;
            }
            double average = (double)sum / (double)counter;
            return average;
        }

        static double Task_2()
        {
            //Task 2
            //Обчислити max(a, b, c)
            Console.WriteLine("Введіть 3 числа: ");
            Console.Write("x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("z: ");
            double z = double.Parse(Console.ReadLine());

            double mySqrt = Math.Sqrt(x * x + y * y);
            double myDiv = z * z * z / 6;

            double a = 2 * mySqrt - myDiv;
            double b = 1 - mySqrt;
            double c = Math.Sin(myDiv) + Math.Cos(Math.PI / 4);
            Console.WriteLine($"\na: {a}\nb: {b}\nc: {c}");
            return Math.Max(a, b) < c ? c : Math.Max(a, b);
        }

        static void Task_3()
        {
            //Task 3
            //Дано матрицю B:7x5. Утворити і надрукувати вектор c,
            //елементами якого є суми додатніх елементів стовпців матриці B.
            //Знайти номер мінімального елемента вектора c.
            int[,] matrixB = new int[,] {
            {-1, 2, -5, 3, 5}, {14, -9, 2, 1, 4}, {-2, -6, 12, 16, -10}, 
            {-5, -6, 1, 6, -10}, {1, 21, -4, 13, -7}, {1, 2, 4, 3, -7}, {-1, 1, -4, 13, -12}
            };

            for (uint i = 0; i < matrixB.GetLength(0); i++) 
            { 
                for (uint j = 0; j< matrixB.GetLength(1); j++) 
                {
                    Console.Write($"{matrixB[i ,j]}\t");
                }
                Console.WriteLine("\n");
            }

            List<uint> c = new List<uint>();
            for (uint j = 0; j < matrixB.GetLength(1); j++)
            {
                int sum = 0;
                for (uint i = 0; i < matrixB.GetLength(0); i++)
                {
                        sum += matrixB[i, j] > 0 ? matrixB[i, j] : 0;
                }
                c.Add((uint)sum);
            }

            Console.Write("Вектор суми додатніх елементів стовпців матриці B: ");
            foreach (uint elem in c)
            {
                Console.Write($"{elem}  ");
            }
            Console.WriteLine($"\nНомер мінімального елемента вектора c - {c.IndexOf(c.Min()) + 1}");
        }
    }
    
}