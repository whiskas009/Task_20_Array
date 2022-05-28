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

            Console.WriteLine("Исходная матрица: ");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]);              
                }
                Console.WriteLine("");
            }

            Console.WriteLine("\nВведите номер строки, сумму которой необходимо узнать: \n");
            int numberString = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Введите номер стобца, произведение которой необходимо узнать: \n");
            int numberColumn = int.Parse(Console.ReadLine()) - 1;

            int sumString = 0;
            int columnProduct = 1;

            for (int i = 0; i < array.GetLength(1); i++)
            {
                sumString += array[numberString, i];
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                columnProduct *= array[i, numberColumn];
            }

            Console.WriteLine($"\nСумма строки равна : {sumString}");
            Console.WriteLine($"Произведение столбца равно: {columnProduct}\n");
        }
    }
}
