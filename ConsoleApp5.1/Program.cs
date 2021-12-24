using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] Mas = new int[16];
            int n = 4;
            int[,] Mas1 = new int[n, n];
            int rows = Mas.GetUpperBound(0) + 1;
            int rows1 = Mas1.GetUpperBound(0) + 1;
            Random rand = new Random();
            for (int i = 0; i < Mas.Length; i++)
            {
                Mas[i] = rand.Next(45);
            }
            for (int i = 0; i < rows; i++)
            {
                Console.Write($"{Mas[i]}\t");
            }
            for (int i = 0; i < Mas1.Length; i++)
            {
                for (int j = 0; j < Mas1.Length; j++)
                {
                    Mas1[i, j] = Mas[i];
                    for (int g = 0; g < rows1; g++)
                    {
                        Console.Write($"{Mas1[i, j]}\t");
                    }
                }

            }






        }
    }
}
