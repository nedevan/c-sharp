// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает
// вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
namespace Program
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("----------------------------");
            int a = GetInt("Введите трехзначное число: ", true);
            
            Console.WriteLine(a.ToString()[1]);
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
