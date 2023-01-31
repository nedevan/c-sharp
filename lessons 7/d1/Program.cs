// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// Пример: m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
namespace Program
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("----------------------------");
            int length = GetInt("Задайте количество строк массива: ");
            int columns = GetInt("Задайте количество столбцов массива: ", true);

            double[,] Array = new double[length, columns];
            FillArray(Array, length, columns);
            PrintArray(Array, length, columns);

            Console.WriteLine();
            Console.WriteLine("Если хочешь выйти CTRL + C");

            Main();
        }

        private static void PrintArray(double[,] array, int length = 0, int columns = 0)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"\t{array[i, j]} ");
                }
                
                Console.WriteLine();
            }
        }

        private static void FillArray(double[,] array, int length = 0, int columns = 0)
        {
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToDouble(rnd.Next(-100, 100) / 10.0);
                }
            }
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
