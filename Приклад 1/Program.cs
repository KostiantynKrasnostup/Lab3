namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            int j;

            // Одновимірний масив iArray
            Console.WriteLine("\n\nОдновимірний масив iArray");
            int[] iArray = new int[10];

            // Присвоєння значень елементам масиву у циклі
            for (j = 0; j < 10; j++)
                iArray[j] = j * j;

            // Виведення елементів масиву
            for (j = 0; j < 10; j++)
                Console.WriteLine("\n" + j + " " + iArray[j]);

            // Одновимірний масив chArray з ініціалізацією
            Console.WriteLine("\nОдновимірний масив chArray з ініціалізацією");
            char[] chArray = { 'a', 'b', 'c', 'd' };
            j = -1;

            // Виведення елементів масиву chArray
            do
            {
                j++;
                Console.WriteLine("\n" + j + " " + chArray[j]);
            }
            while (chArray[j] != 'd');

            // Значення присвоєно не всім елементам масиву iiArray
            Console.WriteLine("\nЗначення присвоєно не всі елементи масиву iiArray\n");
            int[] iiArray = new int[10];

            for (j = 0; j < 6; j++)
                iiArray[j] = j * j;

            // Присвоєння значення останньому елементу
            iiArray[9] = 81;

            // Виведення всіх елементів масиву iiArray
            foreach (int jj in iiArray)
            {
                Console.Write(" " + jj);
            }

            Console.WriteLine("\n\n");
            Console.ReadKey();
        }
    }
}
