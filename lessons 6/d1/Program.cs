// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
namespace Program
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("----------------------------");
            Console.Write("Введите элементы(через пробел): ", true);

            string? text = Console.ReadLine();
            if (text == null)
            {
                return;
            }

            string[] elements = text.Split();
            int[] arr = Array.ConvertAll(elements, int.Parse);
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"Кол-во элементов > 0: {count}");
            Console.WriteLine();
            
            Console.WriteLine("Если хочешь выйти CTRL + C");

            Main();
        }
    }
}
