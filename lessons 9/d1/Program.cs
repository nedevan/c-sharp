// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке 
// от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
namespace Program
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("----------------------------");
            DecrementByNamber(GetInt("Введите число: ", true));

            Console.WriteLine("Если хочешь выйти CTRL + C");

            Main();
        }

        // Уменьшение числа
        private static void DecrementByNamber(int number)
        {
            if (number > 1)
            {
                Console.Write("{0} -> ", number);
                DecrementByNamber(number - 1);
                return;
            }

            if (number == 1 && number > 0)
            {
                Console.WriteLine("{0}.", number);
                DecrementByNamber(number - 1);
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
