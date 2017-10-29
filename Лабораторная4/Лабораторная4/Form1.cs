using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная4
{
    public partial class Form1 : Form
    {
        private static double a = 0;

        private static double b = 1;

        private static double fx;

        private static int m = 10;

        private static double h = (b - a) / m;

        private static int n = 6;

        private static double e = 0.00000001;

        private static double[,] table = new double[m + 1, 3];

        public Form1()
        {
            InitializeComponent();
            CreateTable();
            label2.Text += m + ":";
        }

        private double f(double x)
        {
            return Math.Exp(-x) - (Math.Pow(x, 2)) / 2;
        }

        private double dtf(double x)
        {
            return (-1) * Math.Exp(-x) - x;
        }

        private double ddtf(double x)
        {
            return Math.Exp(-x) - 1;
        }

        private double xj(int j)
        {
            return a + j * h;
        }

        /// <summary>
        /// заполняет таблицу table самой точкой x и значением функции f  в этой точке, m + 1 раз
        /// </summary>
        private void CreateTable()
        {
            for (int j = 0; j <= m; ++j)
            {
                table[j, 0] = xj(j);
                table[j, 1] = f(table[j, 0]);
                listView1.Items.Add(new ListViewItem(new[] { table[j, 0].ToString(), table[j, 1].ToString() }));
            }
        }

        private static void Print()
        {
            for (int j = 0; j <= m; ++j)
            {
                Console.WriteLine("| x = " + table[j, 0] + "    f(xj) = " + table[j, 1]);
            }
        }

        private double[,] SortingBy(double[,] tables, double t)
        {
            for (int i = 0; i < m + 1; ++i)
            {
                tables[i, 2] = Math.Abs(tables[i, 0] - t);
            }

            for (int i = 0; i < m + 1; ++i)
            {
                for (int j = 0; j < m - i; ++j)
                {
                    if (tables[j, 2] > tables[j + 1, 2])
                    {
                        double x = tables[j, 0];
                        double fx = tables[j, 1];
                        double tmp = tables[j, 2];
                        tables[j, 0] = tables[j + 1, 0];
                        tables[j, 1] = tables[j + 1, 1];
                        tables[j, 2] = tables[j + 1, 2];
                        tables[j + 1, 0] = x;
                        tables[j + 1, 1] = fx;
                        tables[j + 1, 2] = tmp;
                    }
                }
            }
            return tables;
        }

        private double Pn(double[,] tables, double[,] mas, double x)
        {           
            var result = mas[0, 1];
            for (int k = 0; k < n; ++k)
            {
                double multi = 1;
                for (int j = 0; j <= k; ++j)
                {
                    multi *= x - mas[j, 0];
                }
                result += multi * mas[k + 1, k + 2];
            }
            return result;
        }

        private void FirstMethodUseNewthonPolinom()
        {
            var tables = new double[m + 1, 3];
            for (int j = 0; j <= m; ++j)
            {
                tables[j, 0] = table[j, 1];
                tables[j, 1] = table[j, 0];
            }
            tables = SortingBy(tables, fx);
            double[,] mas = new double[n + 1, n + 3];
            for (int i = 0; i <= n; ++i)
            {
                mas[i, 0] = tables[i, 0];
                mas[i, 1] = tables[i, 1];
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
            var result = Pn(tables, mas, fx);
            res1.Text = result.ToString();
            rn1.Text = Math.Abs(fx - f(result)).ToString();
        }

        private void SecondMethod()
        {
            var index = 0;
            for (int j = 0; j < m; ++j)
            {
                if((fx >= table[j, 1]) && (fx <= table[j + 1, 1]) || (fx <= table[j, 1]) && (fx >= table[j + 1, 1]))
                {
                    index = j;
                }
            }
            var mid = (table[index, 0] + table[index + 1, 0]) / 2;
            var tables = new double[m + 1, 3];
            for (int j = 0; j <= m; ++j)
            {
                tables[j, 0] = table[j, 0];
                tables[j, 1] = table[j, 1];
            }
            tables = SortingBy(tables, mid);
            double[,] mas = new double[n + 1, n + 3];
            for (int i = 0; i <= n; ++i)
            {
                mas[i, 0] = tables[i, 0];
                mas[i, 1] = tables[i, 1];
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
            List<Cut> intervals = new List<Cut>();
            //separation
            for (double x = a; x <= b; x += h)
            {
                if (((Pn(tables, mas, x) - fx) * (Pn(tables, mas, x + h) - fx) <= 0) && ((x + h) <= b))
                {
                    var cut = new Cut(x, x + h);
                    intervals.Add(cut);
                }
            }
            //bisection method
            foreach (var l in intervals)
            {
                var a = l.a;
                var b = l.b;
                var middle = (b + a) / 2;
                var i = 0;
                while ((b - a) > (2 * e))
                {

                    if ((Pn(tables, mas, middle) - fx) * (Pn(tables, mas, a) - fx) <= 0)
                    {
                        b = middle;
                    }
                    else
                    {
                        a = middle;
                    }
                    ++i;
                    middle = (b + a) / 2;
                }
                res2.Text += middle.ToString() + " ";
                rn2.Text += Math.Abs(fx - f(middle)).ToString() + " ";
            }
        }

        private void NumberDiff()
        {
            var df = ((-3) * table[0, 1] + 4 * table[1, 1] - table[2, 1]) / (2 * h);
            var r1 = Math.Abs(dtf(table[0,0]) - df);
            listView2.Items.Add(new ListViewItem(new[] { table[0, 0].ToString(), table[0, 1].ToString(), df.ToString(), r1.ToString() }));
            double ddf = 0;
            double r2 = 0;
            for (int j = 1; j <= m - 1; ++j)
            {
                df = (table[j + 1, 1] - table[j - 1, 1]) / (2 * h);
                r1 = Math.Abs(dtf(table[j, 0]) - df);
                ddf = (table[j - 1, 1] - 2 * table[j, 1] + table[j + 1, 1]) / (h * h);
                r2 = Math.Abs(ddtf(table[j, 0]) - ddf);
                listView2.Items.Add(new ListViewItem(new[] { table[j, 0].ToString(), table[j, 1].ToString(), df.ToString(), r1.ToString(), ddf.ToString(), r2.ToString() }));
            }
            df = (3 * table[m, 1] + (-4) * table[m - 1, 1] + table[m - 2, 1]) / (2 * h);
            r1 = Math.Abs(dtf(table[m, 0]) - df);
            listView2.Items.Add(new ListViewItem(new[] { table[m, 0].ToString(), table[m, 1].ToString(), df.ToString(), r1.ToString() }));
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            res1.Text = "";
            res2.Text = "";
            rn1.Text = "";
            rn2.Text = "";
            if (xBox.Text == "" || nBox.Text == "")
            {
                var er = new Error("Вы неправильно ввели f(x) или n");
                er.Show();
            }
            else
            {
                fx = Convert.ToDouble(xBox.Text);
                n = Convert.ToInt32(nBox.Text);
                if ((fx > f(a)) || (fx < f(b)) || (n > m) || (n < 0))
                {
                    var er = new Error("Вы неправильно ввели f(x) или n");
                    er.Show();
                }
                else
                {
                    FirstMethodUseNewthonPolinom();
                    SecondMethod();
                    NumberDiff();
                }
            }
        }
    }
}
