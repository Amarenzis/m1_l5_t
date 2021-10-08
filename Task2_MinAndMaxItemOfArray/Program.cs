using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_MinAndMaxItemOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пример реализован на основе целочисленных значений
            
            int l = 15;
            Console.WriteLine("Случайно сгенерированный список из {0} чисел:", l);
            Console.WriteLine();

            
            int[] array = new int[l];
            Random random = new Random();
            int arrayMin = 50;
            int arrayMax = 0;
            int arrayMaxMinSum = 0;


            for (int i = 0; i < l; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);
                if (array[i]<arrayMin)
                {
                    arrayMin = array[i];
                }
                else if (array[i] > arrayMax)
                {
                    arrayMax = array[i];
                }
            }
            arrayMaxMinSum = arrayMax + arrayMin;
            Console.WriteLine();
            Console.WriteLine("Максимальное число - {0}, минимальное число {1}. Их сумма равна {2}",arrayMax,arrayMin,arrayMaxMinSum);
            Console.ReadKey();
        }
    }
}
