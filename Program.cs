using System;

namespace DZ3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool arrRangeCheck = false;
            int arrN = 0;
            do
            {
                Console.Write("Enter Array NxN size : ");
                arrRangeCheck = Int32.TryParse(Console.ReadLine(), out arrN);
                if (!arrRangeCheck)
                {
                    Console.WriteLine("Wrong Array enter; ");
                }
                if (arrN <= 0)
                {
                    arrRangeCheck = false;
                    Console.WriteLine("Wrong Array Size enter; ");
                }
            } while (!arrRangeCheck);

            int[,] array = new int[arrN, arrN];

            int min = 0;
            int max = 0;
            double mid = 0;
            Random rand = new Random();
            for (int i = 0; i < arrN; i++)
            {
                for (int j = 0; j < arrN; j++)
                {
                    array[i, j] = rand.Next(100);
                    mid += array[i, j];
                    if (i == 0 && j == 0)
                    {
                        min = array[i, j];
                        max = array[i, j];
                    }
                    else
                    {
                        min = Math.Min(array[i, j], min);
                        max = Math.Max(array[i, j], max);
                    }
                }
            }
            mid /= (arrN*arrN);
            string tab = "-";
            for (int i = 0; i < arrN; i++)
            {
                tab += "--------";
            }

            Console.Clear();

            for (int i = 0; i < arrN; i++)
            {
                Console.WriteLine(tab);
                for (int j = 0; j < arrN; j++)
                {
                    Console.Write("|" + array[i, j] + "\t");
                }
                Console.WriteLine("|");
            }
            Console.WriteLine(tab);
            Console.WriteLine("\nMin element = " + min);
            Console.WriteLine("Max element = " + max);
            Console.WriteLine($"Middle element = {mid:0.00}");

            Console.ReadKey();


        }
    }
}
