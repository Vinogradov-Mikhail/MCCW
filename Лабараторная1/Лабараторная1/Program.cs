using System;
using System.Collections.Generic;

namespace Лабараторная1
{
    public class Cut
    {
        public double a { set; get; }

        public double b { set; get; }

        public Cut(double c, double d)
        {
            a = c;
            b = d;
        }
    }

    class Program
    {
        private static double A = -3;

        private static double B = 5;

        private static double e = 0.00000001;

        private static double h = 0.0001;

        //list of intervals
        private static List<Cut> intervals;

        /// <summary>
        /// function
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private static double f(double x)
        {
            return Math.Pow(2, -x) + (0.5) * (Math.Pow(x, 2)) - 10;
        }

        /// <summary>
        /// diff of function
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private static double df(double x)
        {
            return (-Math.Log(2)) * Math.Pow(2, -x) + x;
        }

        /// <summary>
        /// double diff of function
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private static double d2f(double x)
        {
            return (-Math.Pow(Math.Log(2), 2)) * Math.Pow(2, -x) + 1;
        }

        /// <summary>
        /// separation of roots
        /// </summary>
        private static void SeparationRoots()
        {
            intervals = new List<Cut>();           
            for (double x = A; x <= B; x += h)
            {
                if ((f(x) * f(x + h) <= 0) && ((x + h) <= B))
                {
                    var cut = new Cut(x, x + h);
                    intervals.Add(cut);
                }
            }
            foreach (var interval in intervals)
            {
                Console.Write("[ " + interval.a + "; " + interval.b + "] ");
            }
        }

        /// <summary>
        /// bisection method
        /// </summary>
        private static void BisectionMethod()
        {           
            foreach(var l in intervals)
            {
                var a = l.a;
                var b = l.b;
                Console.WriteLine("[ " + a + "; " + b + "] ");
                var middle = (b + a) / 2;
                Console.WriteLine(" Start point: " + middle);
                var i = 0;
                double length = 0;
                while((b - a) > (2*e))
                {
                                    
                    if(f(middle) * f(a) < 0)
                    {
                        b = middle;
                    }
                    else
                    {
                        a = middle;
                    }
                    ++i;
                    middle = (b + a) / 2;                   
                    length = Math.Abs(b - a);
                }
                var s1 = b - a;
                Console.WriteLine("Step count: " + i);
                Console.WriteLine("Approximate solution: " + middle);
                Console.WriteLine("Length last cut: " + length);
                Console.WriteLine("Absolute value of the discrepancy: " + Math.Abs(f(middle) - 0) + "\n");
            }
        }

        private static void NewthonMethod()
        {
            foreach (var l in intervals)
            {
                var a = l.a;
                var b = l.b;
                Console.WriteLine("[ " + a + "; " + b + "] ");
                double x0, xn;
                if (f(a) * d2f(a) > 0)
                {
                    x0 = a;
                }
                else
                {
                    x0 = b;
                }
                xn = x0 - f(x0) / df(x0);
                Console.WriteLine(" Start point: " + xn);
                var i = 0;
                while(Math.Abs(x0 - xn) > e)
                {
                    x0 = xn;
                    xn = x0 - f(x0) / df(x0);
                    ++i;
                }
                Console.WriteLine("Step count: " + i);
                Console.WriteLine("Approximate solution: " + xn);
                Console.WriteLine("Length last cut: " + Math.Abs(xn - x0));
                Console.WriteLine("Absolute value of the discrepancy: " + Math.Abs(f(xn) - 0) + "\n");
            }
        }

        private static void ModNewthonMethod()
        {
            foreach (var l in intervals)
            {
                var a = l.a;
                var b = l.b;
                Console.WriteLine("[ " + a + "; " + b + "] ");
                double x0, xn;
                if (f(a) * d2f(a) > 0)
                {
                    x0 = a;
                }
                else
                {
                    x0 = b;
                }
                var diff = df(x0);
                xn = x0 - f(x0) / diff;
                Console.WriteLine(" Start point: " + xn);
                var i = 0;
                while (Math.Abs(x0 - xn) > e)
                {
                    x0 = xn;
                    xn = x0 - f(x0) / diff;
                    ++i;
                }
                Console.WriteLine("Step count: " + i);
                Console.WriteLine("Approximate solution: " + xn);
                Console.WriteLine("Length last cut: " + Math.Abs(xn - x0));
                Console.WriteLine("Absolute value of the discrepancy: " + Math.Abs(f(xn) - 0) + "\n");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Численные методы решения нелинейных уравнений");
            Console.WriteLine("A = " + A + "  B = " + B + "  e = " + e);
            Console.WriteLine("f(x) = 2^(-x) + (0.5) * x^2 - 10");
            Console.WriteLine("\n--------Separation of roots-------");
            SeparationRoots();
            Console.WriteLine("\n\n--------Bisection method-------");
            BisectionMethod();
            Console.WriteLine("\n---------Newthon method--------");
            NewthonMethod();
            Console.WriteLine("\n---------Modified Newthon method--------");
            ModNewthonMethod();
            Console.ReadLine();
        }
    }
}
