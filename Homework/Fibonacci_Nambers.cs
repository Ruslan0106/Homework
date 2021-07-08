using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class Fibonacci_Nambers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите колличество итераций");
            Int32.TryParse(Console.ReadLine(), out int iter);

            FibonacciIteration(iter);

            FibonacciImprovedRecursion(iter);

            FibonacciRecursion(iter);

            Console.ReadKey();
        }

        static void FibonacciIteration(int n)
        {
            decimal res;
            decimal f1 = 0;
            decimal f2 = 1;

            Console.WriteLine("Числа Фибоначчи через цикл");
            Console.WriteLine("----------------------------------");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Итерация: {i + 1}  Число Фибоначчи: {f1}");

                res = f1 + f2;
                f1 = f2;
                f2 = res;
            }
            Console.WriteLine("----------------------------------");
        }

        static void FibonacciImprovedRecursion(int i)
        {
            Console.WriteLine("\nЧисла Фибоначчи через улучшенную рекурсию");
            Console.WriteLine("----------------------------------");
            for (int n = 0; n < i; n++)
            {
                Console.WriteLine($"Итерация: {n + 1}  Число Фибоначчи: {FibonacciRecursion(n)}");
            }

            decimal FibonacciRecursion(int n, decimal a = 0, decimal b = 1)
            {
                if (n > 1)
                {
                    return FibonacciRecursion(n - 1, b, a + b);
                }
                else if (n == 0)
                {
                    return a;
                }
                return b;
            }
            Console.WriteLine("----------------------------------");
        }

        static void FibonacciRecursion(int i)
        {
            Console.WriteLine("\nЧисла Фибоначчи через рекурсию");
            Console.WriteLine("----------------------------------");
            for (int n = 0; n < i; n++)
            {
                Console.WriteLine($"Итерация: {n + 1} Число Фибоначчи: {FibonacciRecursion1(n)}");
            }
            decimal FibonacciRecursion1(int n)
            {
                decimal res = 1;
                if (n > 1)
                {
                    res = FibonacciRecursion1(n - 1) + FibonacciRecursion1(n - 2);
                }
                else if (n == 0)
                {
                    return 0;
                }
                return res;
            }
            Console.WriteLine("----------------------------------");
        }
    }
}
