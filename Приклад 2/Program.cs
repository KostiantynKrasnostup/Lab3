using System;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iArray = new int[10];

            // Введення значень
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"Введіть число {j + 1}: ");
                string strValue = Console.ReadLine();
                iArray[j] = Convert.ToInt32(strValue);
            }

            // Виведення елементів
            Console.WriteLine("\nВведені елементи масиву:");
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine($"{j}: {iArray[j]}");
            }

            Console.ReadKey();
        }
    }
}
