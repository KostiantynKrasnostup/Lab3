using System;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            int jnum = 0, N = 20;
            int jAA = 0, jBB = 0;
            int j, k, temp;
            Random rnd = new Random();
            int[] iArray = new int[N];
            int[] jA = new int[N];
            int[] jB = new int[N];

            // Заполнение массива случайными числами
            for (j = 0; j < N; j++)
            {
                iArray[j] = rnd.Next(1, 101);
            }

            // Вывод исходного массива
            Console.WriteLine("\n Вихідний масив \n\n");
            foreach (int jj in iArray)
            {
                Console.Write(" " + jj);
            }
            Console.WriteLine("\n\n");

            // Разделение массива на четные и нечетные элементы
            for (j = 0; j < N; j++)
            {
                jnum = iArray[j] / 2;
                if (iArray[j] == jnum * 2)
                {
                    jA[jAA] = iArray[j];
                    jAA += 1;
                }
                else
                {
                    jB[jBB] = iArray[j];
                    jBB += 1;
                }
            }

            // Вывод массива A
            Console.WriteLine("\n Масив A[] \n\n");
            for (int i = 0; i < jAA; i++)
            {
                Console.Write(" " + jA[i]);
            }
            Console.WriteLine("\n\n");

            // Вывод массива B
            Console.WriteLine("\n Масив B[] \n\n");
            for (int i = 0; i < jBB; i++)
            {
                Console.Write(" " + jB[i]);
            }
            Console.WriteLine("\n\n");

            // Сортировка массива A
            for (k = 0; k < jAA - 1; k++)
            {
                for (j = 0; j < jAA - 1; j++)
                {
                    if (jA[j + 1] < jA[j])
                    {
                        temp = jA[j];
                        jA[j] = jA[j + 1];
                        jA[j + 1] = temp;
                    }
                }
            }

            // Сортировка массива B
            for (k = 0; k < jBB - 1; k++)
            {
                for (j = 0; j < jBB - 1; j++)
                {
                    if (jB[j + 1] < jB[j])
                    {
                        temp = jB[j];
                        jB[j] = jB[j + 1];
                        jB[j + 1] = temp;
                    }
                }
            }

            // Вывод отсортированного массива A
            Console.WriteLine("\n Відсортований масив A[] \n\n");
            for (int i = 0; i < jAA; i++)
            {
                Console.Write(" " + jA[i]);
            }
            Console.WriteLine("\n\n");

            // Вывод отсортированного массива B
            Console.WriteLine("\n Відсортований масив B[] \n\n");
            for (int i = 0; i < jBB; i++)
            {
                Console.Write(" " + jB[i]);
            }
            Console.WriteLine("\n\n");

            Console.ReadKey();
        }
    }
}
