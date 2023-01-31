// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
namespace Program
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("----------------------------");
            int a = GetInt("Введите размер массива: ", true);
            
            int[] myArray = new int[a];
            Random rnd = new Random();

            Console.Write("Вывод массива: ");
            Console.Write("[ ");

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rnd.Next(100, 999);
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(" " + myArray[i] + " ");
            }
            Console.WriteLine(" ]");

            int count = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    count = count + 1;
                }
            }

            Console.WriteLine("Количетво четных чисел = " + count);
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
