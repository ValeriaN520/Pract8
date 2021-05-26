using System;

namespace Практическая_работа_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            int[,] ms = new int[10,10];
            Random rand = new Random();
            for (int i = 0; i < ms.GetLength(0); i++)
            {
                for (int j = 0; j < ms.GetLength(1); j++)
                {
                    ms[i, j] = rand.Next(10);
                    Console.Write($"{ms[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Задание 2");
            int maxDio = 0;
            int p = 0;
            for (int i = 0; i < ms.GetLength(0); i++)
            {
                if (ms[i, i] > maxDio)
                {
                    maxDio = ms[i, i];
                    p = i;
                }
            }
            Console.WriteLine("Максимальный элемент главной диагонали: " + maxDio + " с координатами: " + p + "," + p);
            int b = 9;
            int c = 0;
            int d = 0;
            int k = 0;
            int maxPob = 0;
            while (b >= 0 && c <= 9)
            {
                if (ms[c, b] > maxPob)
                {
                    maxPob = ms[c, b];
                    d = c;
                    k = b;
                }
                c++;
                b--;
            }
            Console.WriteLine("Максимальный элемент побочной диагонали: " + maxPob + " с координатами: " + k + "," + d);
            Console.WriteLine("Задание 3");
            for (int i = 0; i < ms.GetLength(0); i++)
            {
                int sumStol = 0;
                for (int j = 0; j < ms.GetLength(1); j++)
                {
                    sumStol += ms[j, i];
                }
                Console.WriteLine($"Сумма элементов столбца {i}: " + sumStol + " ");
            }
        }
    }
}
