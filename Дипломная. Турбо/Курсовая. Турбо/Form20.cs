using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая.Турбо
{
    public partial class Example3Form : Form
    {
        public Example3Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            label7.Text = "";
            label8.Text = "";

            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);

            if (a == 0 && b == 0)
            {
                label5.Text = "Ошибка!";
            }
            else
            {
                double d = b * b - (4 * a * c);
                label5.Text = "D = " + Convert.ToString(d);

                if (a == 0)
                {
                    double x = (-1 * c) / b;
                    label7.Text = "X = " + Convert.ToString(x);
                }
                else if (d < 0)
                {
                    label5.Text = "Уравнение не имеет корней";
                }
                else if (d == 0 && a != 0)
                {
                    double x = (-1 * b) / (2 * a);
                    label7.Text = "X = " + Convert.ToString(x);
                }
                else if (d > 0 && a != 0)
                {
                    double x1 = (-1 * b + Math.Sqrt(d)) / (2 * a);
                    label7.Text = "X1 = " + Convert.ToString(x1);
                    double x2 = (-1 * b - Math.Sqrt(d)) / (2 * a);
                    label8.Text = "X2 = " + Convert.ToString(x2);
                }
            }       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            ExampleForm exampleform = new ExampleForm();
            exampleform.Visible = true;
        }
    }
}
