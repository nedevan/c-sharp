// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
namespace Program
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("----------------------------");
            int n = GetInt("Введите число N: ");
            int m = GetInt("Введите число M: ", true);

            Console.WriteLine($"Функция Аккермана: {AkkermanFunction(m, n)}");
            Console.WriteLine("Если хочешь выйти CTRL + C");

            Main();
        }

        private static long AkkermanFunction(long m, long n)
        {
            if (m == 0)
            {
                return n + 1;
            }

            if (m > 0 && n == 0)
            {
                return AkkermanFunction(m - 1, 1);
            }

            return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
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
