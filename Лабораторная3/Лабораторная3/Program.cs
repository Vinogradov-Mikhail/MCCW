using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная3
{
    class Program
    {
        private static double a = 0;

        private static double b = 1;

        private static double x;

        private static int m = 10;

        private static double h = (b - a) / m;

        private static int n = 6;

        private static double[,] table = new double[m + 1, 3];

        private static double f(double x)
        {
            return 1 - Math.Exp((-2) * x);
        }

        private static double xj(int j)
        {
            return a + j * h;
        }

        /// <summary>
        /// заполняет таблицу table самой точкой x и значением функции f  в этой точке, m + 1 раз
        /// </summary>
        private static void CreateTable()
        {
            for (int j = 0; j <= m; ++j)
            {
                table[j, 0] = xj(j);
                table[j, 1] = f(table[j, 0]);
            }
        }

        private static void Print()
        {
            Console.WriteLine("-----------------");
            for (int j = 0; j <= m; ++j)
            {
                Console.WriteLine("| x = " + table[j, 0] + "    f(xj) = " + table[j, 1]);
            }
            Console.WriteLine("-----------------");
        }

        private static int Factorial(int i)
        {
            int result;

            if (i == 1)
                return 1;
            result = Factorial(i - 1) * i;
            return result;
        }

        private static void NewtonPolinomStart()
        {
            double[,] mas = new double[m + 1, m + 3];
            for (int i = 0; i <= m; ++i)
            {
                mas[i, 0] = table[i, 0];
                mas[i, 1] = table[i, 1];
            }
            var start = 1;
            for (int j = 2; j <= m + 2; ++j)
            {        
                for (int i = 0; i <= (m - start); ++i)
                {
                    mas[i, j] = mas[i + 1, j - 1] - mas[i, j - 1];                   
                }
                ++start;
            }
            var t = (x - a) / h;
            var result = mas[0, 1];
            for (int k = 0; k < n; ++k)
            {
                double multi = 1;
                for (int j = 0; j <= k; ++j)
                {
                    multi *= t - j;
                }
                result += multi * mas[0, k + 2] / (Factorial(k + 1));
            }
            Console.WriteLine("В форме Ньютона Pn(x) = " + result);
            Console.WriteLine("efn(x) = " + Math.Abs(f(x) - result));
        }

        private static void NewtonPolinomEnd()
        {
            double[,] mas = new double[m + 1, m + 3];
            for (int i = 0; i <= m; ++i)
            {
                mas[i, 0] = table[i, 0];
                mas[i, 1] = table[i, 1];
            }
            var start = 1;
            for (int j = 2; j <= m + 2; ++j)
            {
                for (int i = 0; i <= (m - start); ++i)
                {
                    mas[i, j] = mas[i + 1, j - 1] - mas[i, j - 1];
                }
                ++start;
            }
            var t = (x - b) / h;
            var result = mas[m, 1];
            for (int k = 0; k < n; ++k)
            {
                double multi = 1;
                for (int j = 0; j <= k; ++j)
                {
                    multi *= t + j;
                }
                result += multi * mas[m - (k + 1), k + 2] / (Factorial(k + 1));
            }
            Console.WriteLine("В форме Ньютона Pn(x) = " + result);
            Console.WriteLine("efn(x) = " + Math.Abs(f(x) - result));
        }

        private static int GetNearIndex(double[,] mas)
        {
            double dist = 100;
            var index = 0;
            for(int i = 0; i <= n; ++i)
            {
                if(Math.Abs(mas[i, 0] - x) < dist)
                {
                    index = i;
                    dist = Math.Abs(mas[i, 0] - x);
                }
            }        
            return index;
        }

        private static void Gauss()
        {
            double[,] mas = new double[n + 1, n + 3];
            int istart = (m - n) / 2;
            for (int i = istart; i <= n + istart; ++i)
            {
                mas[i - istart, 0] = table[i, 0];
                mas[i - istart, 1] = table[i, 1];
            }
            var start = 1;
            for (int j = 2; j <= n + 2; ++j)
            {
                for (int i = 0; i <= (n - start); ++i)
                {
                    mas[i, j] = mas[i + 1, j - 1] - mas[i, j - 1];
                }
                ++start;
            }
            int mid = GetNearIndex(mas);
            var t = (x - mas[mid, 0]) / h;
            var result = mas[mid, 1];
            var p = new List<double>();
            for (int k = 0; k < n; ++k)
            {
               
                double multi = 1;
                for (int j = 0; j <= k; ++j)
                {
                    multi *= t + ((j + 1) / 2) * Math.Pow((-1), j);               
                }
                result += multi * mas[mid - ((k + 1) / 2), k + 2] / (Factorial(k + 1));
                //p.Add(mas[mid - ((k + 1) / 2), k + 2]);
            }
            //Console.WriteLine("-----------------" + (((n - 1 + 1) / 2)) + "-------");
            //for (int i = 0; i <= n; ++i)
            //{
            //    for (int j = 0; j <= n + 1; ++j)
            //        Console.Write(mas[i, j] + " ");
            //    Console.WriteLine(" ");
            //}
            //Console.WriteLine("-----------------");
            //foreach (var s in p)
            //{
            //    Console.Write(s + " ");
            //}
            Console.WriteLine("В форме Гаусса Pn(x) = " + result);
            Console.WriteLine("efn(x) = " + Math.Abs(f(x) - result));
            
        }

        static void Main(string[] args)
        {
            int p = 1 / 2;
            CreateTable();
            Print();
            var delta = (h * (n + 1) / 2);
            do
            {             
                Console.WriteLine("Введите x из промежутков [ " + a + "; " + (a + h) + "], [" + (b - h) + "; " + b + "], [" + (a + delta) + "; " + (b - delta) + "]");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите степень n интерполяционного многочлена <= " + m + " :");
                n = Convert.ToInt32(Console.ReadLine());
                if ((x < a) || (x > b))
                {
                    Console.WriteLine("Вы неправильно ввели x");
                }
                if (n > m)
                {
                    Console.WriteLine("Вы неправильно ввели n");
                }
            } while ((x < a) || (x > b) || (n > m));
            Print();

            if((x >= a) && (x <= (a + h)))
            {
                NewtonPolinomStart();
            }
            else
            {
                if ((x >= (b - h)) && (x <= b))
                {
                    NewtonPolinomEnd();
                }
                else
                {
                    Gauss();
                }
            }            
        }
    }
}
