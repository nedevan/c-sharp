// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
namespace Program
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("----------------------------");
            int number = GetInt("Введите число дня недели: ", true);

            if (number == 1)
            {
                Console.WriteLine("Понедельник не является выходным днем");
            }

            if (number == 2)
            {
                Console.WriteLine("Вторник не является выходным днем");
            }

            if (number == 3)
            {
                Console.WriteLine("Среда не является выходным днем");
            }

            if (number == 4)
            {
                Console.WriteLine("Четверг не является выходным днем");
            }

            if (number == 5)
            {
                Console.WriteLine("Пятница не является выходным днем");
            }

            if (number == 6)
            {
                Console.WriteLine("Суббота выходной день");
            }

            if (number == 7)
            {
                Console.WriteLine("Воскресенье выходной день");
            }

            if (number > 7 || number < 1)
            {
                Console.WriteLine("Ошибка ввода");
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
