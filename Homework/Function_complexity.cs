using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class Function_complexity
    {
        // Сложность функции = O(f(N^3)) = O(N^3)
        static void Main(string[] args)
        {
            var random = new Random();

            int[] array = new int[1000];
            for (int i = 0; i < array.Length; i++)             // O(N)
            {
                array[i] = random.Next(1, 30);
            }

            int sum = StrangeSum(array);

            Console.WriteLine(sum);
            Console.ReadKey();
        }

        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++)     //O(f(N^3))
            {
                for (int j = 0; j < inputArray.Length; j++)
                {
                    for (int k = 0; k < inputArray.Length; k++)
                    {
                        int y = 0;

                        if (j != 0)
                        {
                            y = k / j;
                        }

                        sum += inputArray[i] + i + k + j + y;
                    }
                }
            }
            return sum;
        }
    }
}
