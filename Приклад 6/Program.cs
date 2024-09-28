using System;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, num, sum = 0;
            Random rnd = new Random();
            int[] iArray = new int[10];

            // Заполнение массива случайными числами от 1 до 100
            for (j = 0; j < 10; j++)
            {
                iArray[j] = rnd.Next(1, 101);
            }

            // Подсчет суммы четных элементов массива
            for (j = 0; j < 10; j++)
            {
                num = Convert.ToInt32(iArray[j] % 2);
                if (num == 0) sum += iArray[j];
            }

            // Вывод массива на экран
            foreach (int jj in iArray)
            {
                Console.Write(" " + jj);
            }

            // Пустая строка для форматирования вывода
            Console.WriteLine("\n\n");

            // Вывод суммы четных элементов
            Console.WriteLine("\n Сума парних елементів = " + sum);

            // Ожидание нажатия клавиши перед завершением программы
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
