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
    public partial class Example2Form : Form
    {
        public Example2Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double square = Math.Pow(x, 2);
            label6.Text = Convert.ToString(square);
            double cube = Math.Pow(x, 3);
            label7.Text = Convert.ToString(cube);
            double sqrt = Math.Sqrt(x);
            label8.Text = Convert.ToString(sqrt);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            ExampleForm exampleform = new ExampleForm();
            exampleform.Visible = true;
        }
    }
}
