using System;
using System.IO;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayB = new int[10];
            string userInput;
            int choice;

            Console.WriteLine("Виберіть метод заповнення масиву:");
            Console.WriteLine("1. Генерація випадкових чисел");
            Console.WriteLine("2. Введення з клавіатури");
            Console.WriteLine("3. Читання з файлу");

            // Вибір методу заповнення масиву
            userInput = Console.ReadLine();
            choice = int.TryParse(userInput, out choice) ? choice : 1; // За замовчуванням - 1

            switch (choice)
            {
                case 1:
                    // Генерація випадкових чисел
                    Random rnd = new Random();
                    Console.WriteLine("Генерація масиву випадкових чисел:");
                    for (int i = 0; i < arrayB.Length; i++)
                    {
                        arrayB[i] = rnd.Next(1, 101);
                    }
                    break;

                case 2:
                    // Введення з клавіатури
                    Console.WriteLine("Введіть 10 елементів масиву B (через пробіл):");
                    userInput = Console.ReadLine();
                    string[] inputNumbers = userInput.Split(' ');

                    for (int i = 0; i < arrayB.Length; i++)
                    {
                        if (i < inputNumbers.Length && int.TryParse(inputNumbers[i], out int value))
                        {
                            arrayB[i] = value;
                        }
                        else
                        {
                            Console.WriteLine($"Невірне значення, елемент {i + 1} буде заповнено 0.");
                            arrayB[i] = 0;
                        }
                    }
                    break;

                case 3:
                    // Читання з файлу
                    Console.WriteLine("Введіть шлях до файлу (файл повинен містити 10 чисел):");
                    string filePath = Console.ReadLine();

                    try
                    {
                        string[] fileNumbers = File.ReadAllLines(filePath);
                        for (int i = 0; i < arrayB.Length; i++)
                        {
                            if (i < fileNumbers.Length && int.TryParse(fileNumbers[i], out int value))
                            {
                                arrayB[i] = value;
                            }
                            else
                            {
                                Console.WriteLine($"Невірне значення у файлі, елемент {i + 1} буде заповнено 0.");
                                arrayB[i] = 0;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Помилка при читанні з файлу: " + ex.Message);
                    }
                    break;

                default:
                    Console.WriteLine("Неправильний вибір, використано генерацію випадкових чисел за замовчуванням.");
                    Random random = new Random();
                    for (int i = 0; i < arrayB.Length; i++)
                    {
                        arrayB[i] = random.Next(1, 101);
                    }
                    break;
            }

            // Виведення масиву B
            Console.WriteLine("\nМасив B[]:");
            foreach (int num in arrayB)
            {
                Console.Write(" " + num);
            }
            Console.WriteLine();

            // Сортування масиву B
            Array.Sort(arrayB);

            // Виведення відсортованого масиву B
            Console.WriteLine("\nВідсортований масив B[]:");
            foreach (int num in arrayB)
            {
                Console.Write(" " + num);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
