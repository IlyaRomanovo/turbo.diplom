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
    public partial class Example1Form : Form
    {
        public Example1Form()
        {
            InitializeComponent();
        }

        private void Form18_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label9.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 20);
            label10.Text = Convert.ToString(Convert.ToInt32(textBox2.Text) * 30);
            label11.Text = Convert.ToString(Convert.ToInt32(textBox3.Text) * 10);
            label19.Text = Convert.ToString(Convert.ToInt32(label9.Text) + Convert.ToInt32(label10.Text) + Convert.ToInt32(label11.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label9.Text = "0";
            label10.Text = "0";
            label11.Text = "0";
            label19.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            ExampleForm exampleform = new ExampleForm();
            exampleform.Visible = true;
        }
    }
}
