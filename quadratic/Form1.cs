using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quadratic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "") textBox4.Text = "Ошибка. Введите коэффициенты.";
            else
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int c = int.Parse(textBox3.Text);

                double D = Disc(a, b, c);
                double x1 = x1_(a, b, D);
                double x2 = x2_(a, b, D);

                textBox4.Text = "Дискриминант (D) = " + D + Environment.NewLine +
                                "x1 = " + x1 + Environment.NewLine +
                                "x2 = " + x2 + Environment.NewLine;

                if (D < 0) textBox4.Text += "Уравнение не имеет корней, т.к. D < 0";
                if (D == 0) textBox4.Text += "Уравнение имеет равные корни, т.к. D = 0";
                if (D > 0) textBox4.Text += "Уравнение имеет два корня, т.к. D > 0";
            }
        }

        public double Disc(int a, int b, int c)
        {
            double D = Math.Pow(b, 2) - 4 * a * c;
            return D;
        }

        public double x1_(int a, int b, double D)
        {
            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            return x1;
        }
        public double x2_(int a, int b, double D)
        {
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);
            return x2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
