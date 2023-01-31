// ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
namespace Program
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("----------------------------");
            int x = GetInt("Введите X: ");
            int y = GetInt("Введите Y: ");
            int z = GetInt("Введите Z: ", true);

            int[,,] array3D = new int[x, y, z];
            CreateArray(array3D);
            WriteArray(array3D);

            Console.WriteLine("Если хочешь выйти CTRL + C");

            Main();
        }

        private static void WriteArray(int[,,] array3D)
        {
            for (int i = 0; i < array3D.GetLength(0); i++)
            {
                for (int j = 0; j < array3D.GetLength(1); j++)
                {
                    Console.Write($"X({i}) Y({j}) ");
                    for (int k = 0; k < array3D.GetLength(2); k++)
                    {
                        Console.Write($"Z({k})={array3D[i, j, k]}; ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        private static void CreateArray(int[,,] array3D)
        {
            int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
            int number;
            for (int i = 0; i < temp.GetLength(0); i++)
            {
                temp[i] = new Random().Next(10, 100);
                number = temp[i];
                if (i >= 1)
                {
                    for (int j = 0; j < i; j++)
                    {
                        while (temp[i] == temp[j])
                        {
                            temp[i] = new Random().Next(10, 100);
                            j = 0;
                            number = temp[i];
                        }
                        number = temp[i];
                    }
                }
            }
            int count = 0;
            for (int x = 0; x < array3D.GetLength(0); x++)
            {
                for (int y = 0; y < array3D.GetLength(1); y++)
                {
                    for (int z = 0; z < array3D.GetLength(2); z++)
                    {
                        array3D[x, y, z] = temp[count];
                        count++;
                    }
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
