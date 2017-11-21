using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная5
{
    public partial class Form1 : Form
    {
        private double A;
        private double B;
        private double J;
        private double h;
        private int m;

        public Form1()
        {
            InitializeComponent();
            fxx.Text += "e^x";// "x^2";
        }

        private double f(double x)
        {
            return Math.Exp(x);//Math.Pow(x, 2);
        }

        private void Integral()
        {
            J = Math.Exp(B) - Math.Exp(A);//Math.Pow(B, 3) / 3 - Math.Pow(A, 3) / 3;
            jL.Text = J.ToString();
        }

        private void MiddleRectangle()
        {
            double summ = 0;
            for(int k = 0; k < m; ++k)
            {
                var zk0 = A + k * h;
                var zk1 = A + (k + 1)* h;
                summ += f((zk0 + zk1) / 2);
            }
            var result = h * summ;
            jMR.Text = result.ToString();
            var abs = Math.Abs(J - result);
            absM.Text = "|J - J(h)| = " + abs.ToString();
        }

        private void Trapeze()
        {
            double summ = 0;
            for (int k = 0; k < m; ++k)
            {
                var zk0 = A + k * h;
                var zk1 = A + (k + 1) * h;
                summ += (f(zk0) + f(zk1));
            }
            var result = (h / 2) * summ;
            jT.Text = "J(h) = "+ result.ToString();
            var abs = Math.Abs(J - result);
            absT.Text = "|J - J(h)| = " + abs.ToString();
        }

        private void Simpson()
        {
            double summ = 0;
            for (int k = 0; k < m; ++k)
            {
                var zk0 = A + k * h;
                var zk1 = A + (k + 1) * h;
                summ += (f(zk0) + 4 * f((zk0 + zk1) / 2) + f(zk1));
            }
            var result = (h / 6) * summ;
            jS.Text = "J(h) = " + result.ToString();
            var abs = Math.Abs(J - result);
            absS.Text = "|J - J(h)| = " + abs.ToString();
        }

        private void run_Click(object sender, EventArgs e)
        {
            if (bBox.Text == "" || aBox.Text == "" || mBox.Text == "")
            {
                var er = new Error("Вы неправильно ввели A, B или m");
                er.Show();
            }
            else
            {
                B = Convert.ToDouble(bBox.Text);
                A = Convert.ToDouble(aBox.Text);
                m = Convert.ToInt32(mBox.Text);
                if (A > B)
                {
                    var er = new Error("А не может быть больше B");
                    er.Show();
                }
                else
                {
                    h = (B - A) / m;
                    hL.Text = "h = " + h.ToString();
                    Integral();
                    MiddleRectangle();
                    Trapeze();
                    Simpson();
                }
            }           
        }
    }
}
