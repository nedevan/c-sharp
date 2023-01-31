// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
namespace Program
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("----------------------------");
            int number = GetInt("Введите число дня недели: ", true);
            
            string numberString = number.ToString();
            if (numberString.Length == 5)
            {
                CheckingNumber(numberString);
            }
            else
            {
                Console.WriteLine($"Введи правильное число");
            }

            Console.WriteLine("Если хочешь выйти CTRL + C");

            Main();
        }

        private static void CheckingNumber(string number)
        {
            if (number[0] == number[4] || number[1] == number[3])
            {
                Console.WriteLine($"Ваше число: {number} - палиндром.");
            }
            else
            {
                Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
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