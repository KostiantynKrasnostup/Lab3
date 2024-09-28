using System;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, jnum = 0;
            Random rnd = new Random();
            int[] iArray = new int[20];

            // Заполнение массива случайными числами от -50 до 49
            for (j = 0; j < 20; j++)
            {
                iArray[j] = 50 - rnd.Next(1, 101);
            }

            // Поиск индекса второго положительного элемента
            for (j = 0; j < 20; j++)
            {
                if (iArray[j] > 0) jnum += 1;
                if (jnum == 2) break;
            }

            // Вывод массива на экран
            foreach (int jj in iArray)
            {
                Console.Write(" " + jj);
            }

            // Пустая строка для форматирования вывода
            Console.WriteLine("\n\n");

            // Вывод индекса второго положительного элемента и его значения
            Console.WriteLine("\n Індекс другого позитивного елемента = " + j);
            Console.WriteLine("\n iArray[" + j + "] = " + iArray[j]);

            // Сброс счетчика для поиска третьего отрицательного элемента
            jnum = 0;

            // Поиск индекса третьего отрицательного элемента
            for (j = 0; j < 20; j++)
            {
                if (iArray[j] < 0) jnum += 1;
                if (jnum == 3) break;
            }

            // Вывод индекса третьего отрицательного элемента и его значения
            Console.WriteLine("\n Індекс третього негативного елемента = " + j);
            Console.WriteLine("\n iArray[" + j + "] = " + iArray[j]);

            // Ожидание нажатия клавиши перед завершением программы
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
