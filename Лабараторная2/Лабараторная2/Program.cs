using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабараторная2
{
    class Program
    {
        private static double a = 0;

        private static double b = 1;

        private static double x;

        private static int m = 15;

        private static int n;

        private static double y = 0.6;

        private static double[,] table = new double[m + 1, 3];

        private static double f(double x)
        {
            return Math.Exp(-x) - (Math.Pow(x, 2)) / 2;
        }

        private static double xj(int j)
        {
            return a + (j * (b - a)) / m;
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

        private static void SortingByX()
        {
            for (int i = 0; i < m + 1; ++i)
            {
                table[i, 2] = Math.Abs(table[i, 0] - x);
            }

            for (int i = 0; i < m + 1; ++i)
            {
                for (int j = 0; j < m - i; ++j)
                {
                    if (table[j, 2] > table[j + 1, 2])
                    {
                        double x = table[j, 0];
                        double fx = table[j, 1];
                        double tmp = table[j, 2];
                        table[j, 0] = table[j + 1, 0];
                        table[j, 1] = table[j + 1, 1];
                        table[j, 2] = table[j + 1, 2];
                        table[j + 1, 0] = x;
                        table[j + 1, 1] = fx;
                        table[j + 1, 2] = tmp;
                    }
                }
            }
        }

        private static void LagrnagePolinom()
        {
            double result = 0;           
            for(int j = 0; j <= n; ++j)
            {
                double wx = 1;
                double wxk = 1;
                var xk = table[j, 0];
                for (int i = 0; i <= n; ++i)
                {                    
                    if (i != j)
                    {
                        var xi = table[i, 0];
                        wx *= (x - xi);
                        wxk *= (xk - xi);
                    }
                }
                result += table[j, 1] * (wx / wxk);
            }
            Console.WriteLine("В форме Лагранжа Pn(x) = " + result);
            Console.WriteLine("efn(x) = " + Math.Abs(f(x) - result));
        }

        private static void NewtonPolinom()
        {
            double[,] mas = new double[n + 1, n + 3];
            for (int i = 0; i <= n; ++i)
            {
                mas[i, 0] = table[i, 0];
                mas[i, 1] = table[i, 1];
            }            
            for (int j = 2; j <= n + 2; ++j)
            {
                var start = 1;
                for (int i = start; i <= n; ++i)
                {
                    mas[i, j] = (mas[j - 2, j - 1] - mas[i, j - 1]) / (mas[j - 2, 0] - mas[i, 0]);
                    ++start;
                }
            }
            var result = mas[0, 1];
            for(int k = 0; k < n; ++k)
            {
                double multi = 1;
                for (int j = 0; j <= k; ++j)
                {
                    multi *= x - mas[j, 0];
                }
                result += multi * mas[k + 1, k + 2];
            }
            Console.WriteLine("В форме Ньютона Pn(x) = " + result);
            Console.WriteLine("efn(x) = " + Math.Abs(f(x) - result));
        }

        static void Main(string[] args)
        {
            CreateTable();
            Print();
            do
            {
                Console.WriteLine("Введите x из промежутка [ " + a + "; " + b + "] :");
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
            SortingByX();
            Console.WriteLine("Таблица отсортированная относительно значений х");
            Print();
            LagrnagePolinom();
            NewtonPolinom();
        }
    }
}
