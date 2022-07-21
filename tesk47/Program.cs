//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.

//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

namespace tesk47
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"m = {m}, n = {n}.");
            double[,] array = new double[m, n];
            CreateArrayDouble(array, m, n);
            WriteArray(array, m, n);
            Console.WriteLine();
        }
        public static void CreateArrayDouble(double[,] array, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = new Random().NextDouble() * 20 - 10;
                }
            }
        }

        public static void WriteArray(double[,] array, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    double alignNumber = Math.Round(array[i, j], 1);
                    Console.Write(alignNumber + " ");
                }
                Console.WriteLine();
            }
        }
    }
}