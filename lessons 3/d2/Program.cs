// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
namespace Program
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("----------------------------");
            double x1 = GetToDouble("Введите х1: ");
            double x2 = GetToDouble("Введите х2: ", true);

            double y1 = GetToDouble("Введите y1: ");
            double y2 = GetToDouble("Введите y2: ", true);

            double z1 = GetToDouble("Введите z1: ");
            double z2 = GetToDouble("Введите z2: ", true);

            double dist = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

            Console.WriteLine(dist);
            Console.WriteLine("Если хочешь выйти CTRL + C");

            Main();
        }

        // Получить число из консли
        private static double GetToDouble(string title = "Введите значение: ", bool space = false)
        {
            Console.Write(title);

            double result = 0;
            try
            {
                result = Convert.ToDouble(Console.ReadLine());
                if (space)
                {
                    Console.WriteLine();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Это должно быть числом!");
                Console.WriteLine();

                return GetToDouble(title);
            }

            return result;
        }
    }
}