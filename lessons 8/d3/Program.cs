// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
namespace Program
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("----------------------------");
            int m = GetInt("Введите кол-во строк 1-й матрицы: ");
            int n = GetInt("Введите кол-во столбцов 1-й матрицы (и строк 2-й): ");
            int p = GetInt("Введите кол-во столбцов 2-й матрицы: ");
            int range = GetInt("Введите диапазон случайных чисел: от 1 до ", true);

            int[,] firstMartrix = new int[m, n];
            CreateArray(firstMartrix, range);
            Console.WriteLine($"Первая матрица:");
            WriteArray(firstMartrix);

            int[,] secomdMartrix = new int[n, p];
            CreateArray(secomdMartrix, range);
            Console.WriteLine($"Вторая матрица:");
            WriteArray(secomdMartrix);

            int[,] resultMatrix = new int[m, p];

            MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
            Console.WriteLine($"Произведение первой и второй матриц:");
            WriteArray(resultMatrix);

            Console.WriteLine("Если хочешь выйти CTRL + C");

            Main();
        }

        private static void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
        {
            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    int sum = 0;
                    for (int k = 0; k < firstMartrix.GetLength(1); k++)
                    {
                        sum += firstMartrix[i, k] * secomdMartrix[k, j];
                    }
                    resultMatrix[i, j] = sum;
                }
            }
        }

        private static void CreateArray(int[,] array, int range)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(range);
                }
            }
        }

        private static void WriteArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
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
