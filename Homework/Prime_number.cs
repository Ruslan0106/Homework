using System;

namespace Homework
{
    class Prime_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int n = Int32.Parse(Console.ReadLine());

            int d = PrmNumb(n);

            Answer(d, n);

            Console.ReadKey();
        }

        static int PrmNumb(int n)
        {
            int d = 0;
            int i = 2;

            while (i < n)
            {
                if (n % i == 0)
                {
                    d++;
                    break;
                }
                i++;
            }
            return d;
        }
        static void Answer(int d, int n)
        {
            if (d == 0)
            {
                Console.WriteLine($"Число: {n} простое");
            }
            else
            {
                Console.WriteLine($"Число: {n} Не простое");
            }
        }
    }
}
