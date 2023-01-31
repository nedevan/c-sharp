// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в 
// каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3
namespace Program
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("----------------------------");
            int[,] array = new int[3, 3] { { 1, 5, 8 }, { 4, 9, 4 }, { 7, 2, 2 } };
            for (int i = 0; i < 3; i++)
            {
                int srAr = 0;
                int ColChetn = 0;
                for (int t = 0; t < 3; t++)
                {
                    srAr += array[t, i];
                    ColChetn += (array[t, i] % 2 == 0) ? 1 : 0;
                }
                
                Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {(float)srAr / 3}");
                Console.WriteLine($"Количество четных элементов столбца {i + 1} = {ColChetn}");
            }

            Console.WriteLine();
            Console.WriteLine("Если хочешь выйти CTRL + C");
            Console.ReadLine();

            Main();
        }
    }
}
