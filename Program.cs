using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Вариант 2
Если в заданной матрице A(N, M) есть хотя бы один элемент, больший ста, то
элементы обеих диагоналей замените нулями. */

namespace _4_1_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,]
            {
                { 1, 2, 3 },
                { 4, 101, 6 },
                { 7, 8, 9 }                
            };

            bool flag = false;
            foreach (int i in array)
                if (i > 100)
                    flag = true;

            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    if ((flag) || (i == j) || (- i == j-array.GetLength(0)+1))
                        array[i, j] = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($" {array[i, j]}, ");
                }
                Console.WriteLine();
            }            
            Console.ReadKey();
        }
    }
}
