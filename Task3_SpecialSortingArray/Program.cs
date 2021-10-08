using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_SpecialSortingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = 10;
            Console.WriteLine("Случайно сгенерированный список из {0} чисел:", l);
            Console.WriteLine();

            int[] array = new int[l];
            Random random = new Random();
            int t = 0;

            for (int i = 0; i < l; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0,5}", array[i]);
                if (i == l/2-1)
                {
                    Console.Write("   ||");
                }
            }
            Console.WriteLine("");
            //Console.WriteLine("{0}", l / 2 - 2);
            //Console.WriteLine("{0}", l / 2 - 1);

            for (int i = 0; i < l/2-1; i++)
            {
                for (int j = i + 1; j < l/2; j++)
                {
                    if (array[i] > array[j])
                    {
                        t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            for (int i = l/2; i < l-1; i++)
            {
                for (int j = i + 1; j < l; j++)
                {
                    if (array[i] < array[j])
                    {
                        t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            for (int k = 0; k < l; k++)
            {
                Console.Write("{0,5}", array[k]);
                if (k == l/2-1)
                {
                    Console.Write("   ||");
                }
            }

            Console.ReadKey();
        }
    }
}
