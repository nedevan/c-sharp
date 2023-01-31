// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// Double[] myArray;
namespace Program
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("----------------------------");
            int a = GetInt("Введите размер массива: ", true);

            double[] myArray = new double[a];
            Random rnd = new Random();

            Console.WriteLine("Вывод массива: ");

            // Создание массива
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rnd.Next(-10, 10) + rnd.NextDouble();
            }

            // Вывод массива
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(" " + myArray[i] + " ");
            }

            double max = 0;
            double min = 0;
            double b = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > max)
                {
                    max = myArray[i];
                }

                if (myArray[i] < min)
                {
                    min = myArray[i];
                }

                b = max - min;
            }

            Console.WriteLine();
            Console.WriteLine("Разница между максимальным и минимальным чслом = " + b);
            Console.WriteLine();

            Console.WriteLine("Если хочешь выйти CTRL + C");

            Main();
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
