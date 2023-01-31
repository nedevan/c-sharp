// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
namespace Program
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("----------------------------");
            int rows = GetInt("Введите кол-во строк массива: ");
            int columns = GetInt("Введите кол-во столбцов массива: ");
            int finderElement = GetInt("Введите число, которое необходимо найти: ", true);

            int[,] array = GetArray(rows, columns, 0, 10);
            PrintArray(array);
            FindElementByArray(array, finderElement);

            Console.WriteLine();
            Console.WriteLine("Если хочешь выйти CTRL + C");

            Main();
        }

        private static int[,] GetArray(int rows, int n, int minValue, int maxValue)
        {
            int[,] result = new int[rows, n];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i, j] = new Random().Next(minValue, maxValue + 1);
                }
            }

            return result;
        }

        private static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }

                Console.WriteLine();
            }
        }

        private static void FindElementByArray(int[,] array, int finderElement)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == finderElement)
                    {
                        Console.WriteLine($"Число {finderElement} есть в массиве данных!");
                        return;
                    }
                }

            }

            Console.WriteLine("Введенного числа нет в массиве");
        }

        // Получить число из консли
        private static int GetInt(string title = "Введите значение: ", bool space = false)
        {
            Console.Write(title);

            int result = 0;
            try
            {
                result = Convert.ToInt32(Console.ReadLine());
                if (space)
                {
                    Console.WriteLine();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Это должно быть числом!");
                Console.WriteLine();

                return GetInt(title);
            }

            return result;
        }
    }
}
