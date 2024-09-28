using System;
using System.IO;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            int j;
            string strValue;
            int[] iArray1 = new int[10];
            int[] iArray2 = new int[10];

            // Заміна на правильний синтаксис для створення об'єктів StreamReader та StreamWriter
            StreamReader sRead = new StreamReader("D:\\dat.txt");
            StreamWriter sWrite = new StreamWriter("D:\\res.txt");

            for (j = 0; j < 10; j++)
            {
                // Зчитування значення з файлу
                strValue = sRead.ReadLine();

                // Конвертація рядка в ціле число
                iArray1[j] = Convert.ToInt32(strValue);

                // Обчислення нового значення
                iArray2[j] = 10 * iArray1[j];

                // Форматування рядка для виводу на консоль
                strValue = string.Format("\n {0,4:D} {1,6:D} {2,6:D}", j, iArray1[j], iArray2[j]);

                // Вивід на консоль
                Console.WriteLine(strValue);
                Console.WriteLine();

                // Запис у файл
                sWrite.WriteLine(iArray2[j]);
            }

            // Закриття потоків зчитування та запису
            sRead.Close();
            sWrite.Close();

            // Очікування натискання клавіші, щоб програма не закривалася одразу
            Console.ReadKey();
        }
    }
}
