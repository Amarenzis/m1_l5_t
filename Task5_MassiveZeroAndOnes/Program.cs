using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_MassiveZeroAndOnes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число N:");
            int N = Convert.ToInt32(Console.ReadLine());

            int[,] arrayN = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    //если индексы ячейки одновременно являются четными или нечётными, ставим 1
                    if (((i % 2 == 0) && (j % 2 == 0))|| ((i % 2 == 1) && (j % 2 == 1)))
                    {
                        arrayN[i, j] = 1;
                    }
                    else
                    {
                        arrayN[i, j] = 0;
                    }
                    Console.Write("{0,3}", arrayN[i, j]);
                }
                Console.WriteLine("");
            }
            Console.ReadKey();

        }
    }
}
