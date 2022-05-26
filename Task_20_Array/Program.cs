using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 2, 3} , { 4, 5} };
            int sumString = 0;
            int columnProduct = 1;

            Console.WriteLine("Исходная матрица: ");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]);
                    sumString += array[1, j];
                }
                Console.WriteLine("");
                columnProduct *= array[i, 0];
            }

            Console.WriteLine($"\nСумма второй строки равна : {sumString}");
            Console.WriteLine($"Произведение первого столбца равно: {columnProduct}\n");
        }
    }
}
