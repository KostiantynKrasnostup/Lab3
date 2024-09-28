﻿using System;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, num;
            string str;
            // Переименовал переменные, чтобы не было конфликтов и исправил кавычки
            string str1 = "Сума", str2 = "Сума";
            string str3 = "СрАрф", str4 = "СрАрф";
            double db1, db2;
            double sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;

            // Создание объекта Random для генерации случайных чисел
            Random rnd = new Random();

            // Создание массивов int и double
            int[] iArray1 = new int[15];
            int[] iArray2 = new int[15];
            double[] dArray1 = new double[15];
            double[] dArray2 = new double[15];

            // Заполнение массивов и подсчет суммы элементов
            for (j = 0; j < 15; j++)
            {
                iArray1[j] = rnd.Next(1, 101);
                iArray2[j] = 50 - rnd.Next(1, 101);
                sum1 += iArray1[j];
                sum2 += iArray2[j];
            }

            for (j = 0; j < 15; j++)
            {
                num = rnd.Next(1, 101);
                db1 = Convert.ToDouble(num);
                dArray1[j] = db1 + Convert.ToDouble(rnd.Next(1, 101)) / 100;
                num = 50 - rnd.Next(1, 101);
                db2 = Convert.ToDouble(num);
                dArray2[j] = db2 - Convert.ToDouble(rnd.Next(1, 101)) / 100;
                sum3 += dArray1[j];
                sum4 += dArray2[j]; // Убрал пробел между + и = 
            }

            // Вывод заголовков и результатов на экран
            Console.WriteLine("\n--------------------------------------------------------------");
            Console.WriteLine("\n Масиви типу int                          Масиви типу double");
            Console.WriteLine("--------------------------------------------------------------");

            for (j = 0; j < 15; j++)
            {
                // Использование форматированной строки для вывода значений
                str = string.Format("\n {0,10:D} {1,10:D} {2,10:D} {3,10:D} {4,10:F2} {5,10:F2}", j,
                iArray1[j], iArray2[j], j, dArray1[j], dArray2[j]);
                Console.WriteLine(str);
            }

            Console.WriteLine("--------------------------------------------------------------");

            // Вывод сумм значений массивов
            Console.WriteLine("\n {0} {1,10:F2} {2} {3,10:F2} {4,10:F2}", str1, sum1, str2, sum2, sum3, sum4);
            // Вывод средних арифметических значений массивов
            Console.WriteLine("\n {0} {1,10:F2} {2} {3,10:F2} {4,10:F2}", str3, sum1 / 15, sum2 / 15, str4, sum3 / 15, sum4 / 15);

            Console.ReadKey(); // Ожидание нажатия клавиши
        }
    }
}
