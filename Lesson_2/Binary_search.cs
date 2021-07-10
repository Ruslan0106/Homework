using System;

namespace Lesson_2
{
    class Binary_search
    {
        static void Main(string[] args)
        {
            // Асимптотическая сложность = O(N^2)

            // O(N) + O(N^2) + O(log2N) = O(2N^2) = O(N^2)

            int sizeArr = 100;
            int val = 30;

            int[] array = ArrayRandom(sizeArr);    // O(N)

            Array.Sort(array);                     // O(N^2)

            int iter = BinarySearch(array, val);   //O(log2N)

            if (iter == -1)
            {
                Console.WriteLine($"Число: {val} отсутствует в массиве: Array");
            }
            else
            {
                Console.WriteLine($"Число: {val} находится в Array[{iter}]");
            }

            Console.ReadKey();
        }
        static int[] ArrayRandom(int size)
        {
            Random random = new Random();

            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(1, 50);
            }
            return arr;
        }
        public static int BinarySearch(int[] inputArray, int searchValue)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (searchValue == inputArray[mid])
                {
                    return mid;
                }
                else if (searchValue < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
    }
}
