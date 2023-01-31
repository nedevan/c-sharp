//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
//а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
namespace Program
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("----------------------------");
            int a = GetInt("Введите первое число: ");
            int b = GetInt("Введите второе число: ", true);

            if (a > b)
            {
                Console.WriteLine($"Наибольшее число: {a}");
                Console.WriteLine($"Наименьшее число: {b}");
            }
            else if (b > a)
            {
                Console.WriteLine($"Наибольшее число: {b}");
                Console.WriteLine($"Наименьшее число: {a}");
            }
            else
            {
                Console.WriteLine("Числа равны!");
            }

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
