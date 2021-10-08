using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_CountOddPositiveNumberByPlace
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = 20;
            Console.WriteLine("Считаем позиции с 0, т.е. берем элемент с индексами 0,2,4,6 и т.д.");
            Console.WriteLine("Случайно сгенерированный список из {0} чисел:", l);
            Console.WriteLine();

            int[] array = new int[l];
            Random random = new Random();
            int k = 0;
            int oddPositiveQuantity = 0;

            for (int i = 0; i < l; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0,5}", array[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < l; i = k)
            {
                if ((array[i] > 0) && (array[i] % 2 == 1))
                {
                    oddPositiveQuantity++;
                }
                //Console.WriteLine("Число {0}, счетчик чисел {1}, счетчик места {2}", array[i], oddPositiveQuantity,k);
                k += 2;

            }

            Console.WriteLine("Всего положительных нечетных чисел в последовательности - {0}", oddPositiveQuantity);
            Console.ReadKey();
        }
    }
}
