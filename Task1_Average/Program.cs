using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[7];
            Console.WriteLine("Введите число и нажмите Enter. Цикл повториться 7 раз");
            double arraySum = 0;

            for (int i = 0; i < 7; i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            /*проверка создания массива
            for (int i = 0; i < 7; i++)
            {
                Console.Write("{0} ", array[i]);
            }*/

            foreach (double a in array)
            {
                arraySum += a;
                //Console.WriteLine("{0}", arrayAverage);
            }
            
            Console.WriteLine("");
            Console.WriteLine("Среднее значение массива {0:f2}", (arraySum / 7));
            Console.ReadKey();
        }
    }
}
