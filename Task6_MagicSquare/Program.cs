using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_MagicSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            //сделала не для "нормального" магического квадрата
            Console.WriteLine("Введите целое число N:");
            int N = Convert.ToInt32(Console.ReadLine());
            //int N = 3;
            Console.WriteLine("Введите значения квадрата начиная с индекса 0,0, заканчивая NN");

            //int[,] arrayN = new int[3, 3] { { 2, 7, 6 }, { 9, 5, 1 }, { 4, 3, 8 } };
            int[,] arrayN = new int[N, N];
            int sum = 0;
            int sumTempLines = 0;
            int sumTempColumnes = 0;
            int sumTempMainDiag = 0;
            int sumTempSecDiag = 0;
            int c = 0;
            bool magicSquare = false;


            //Вводим квадрат
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    arrayN[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //Выводим квадрат
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0,5}", arrayN[i, j]);
                }
                Console.WriteLine();
            }
            //Узнаём сумму первой строки (идекс 0)
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    sum += arrayN[i, j];
                }
                Console.WriteLine("Сумма по нулевой строке равна {0}", sum);
                Console.WriteLine("");

            }
            //Узнаём равны ли суммы по строкам(столбцам) равны первой строке
            for (int i = 0; i < N; i++)
            {
                sumTempLines = 0;
                sumTempColumnes = 0;
                for (int j = 0; j < N; j++)
                {
                    sumTempLines += arrayN[i, j];
                    sumTempColumnes += arrayN[j, i];
                }
                if ((sumTempColumnes == sum)&&(sumTempLines==sum))
                {
                    magicSquare = true;
                    Console.WriteLine("Сумма столбца {0} - {1}, сумма строки {2} - {3}", c, sumTempColumnes, i, sumTempLines);
                    Console.WriteLine();
                }
                else
                {

                    Console.WriteLine("Сумма столбца {0} - {1}, сумма строки {2} - {3}", c, sumTempColumnes,i,sumTempLines);
                    Console.WriteLine("Столбцы или строчки не сошлись");
                    break;
                }
                //А теперь сумма по диагоналям
                sumTempMainDiag += arrayN[i, i];
                sumTempSecDiag += arrayN[i, (N - 1) - i];
                c++;
            }
            Console.WriteLine();
            if ((sumTempMainDiag == sum) && (sumTempSecDiag == sum)&&magicSquare)
            {
                Console.WriteLine("Сумма главной диагонали {0}, второй {1}",sumTempMainDiag,sumTempSecDiag);
                magicSquare = true;
                Console.WriteLine("Это магический квадрат");
            }
            else
            {
                Console.WriteLine("Не магический квадрат");
            }




            Console.ReadKey();
        }
    }
}
