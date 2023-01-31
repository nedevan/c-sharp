//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
namespace Program
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("----------------------------");
            int a = GetInt("Введите первое число: ");
            int b = GetInt("Введите второе число: ");
            int c = GetInt("Введите третье число: ", true);

            if (a > b && a > c)
            {
                Console.WriteLine($"Максимальное число: {a}");
            }

            if (b > a && b > c)
            {
                Console.WriteLine($"Максимальное число: {b}");
            }

            if (c > a && c > b)
            {
                Console.WriteLine($"Максимальное число: {c}");
            }

            if (a == c && a == b)
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
