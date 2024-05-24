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
    public partial class DevelopForm : Form
    {
        double testball = 0;
        double maxtestball = 12;
        int testmark = 0;
        public DevelopForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Menu2Form menu2form = new Menu2Form();
            if (menu2form.ShowDialog() != DialogResult.OK)
            {
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form16 form16 = new Турбо.Form16();
            if (form16.ShowDialog() != DialogResult.OK)
            {
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "bind()")
            {
                testball++;
            }
            if (radioButton1.Checked == true)
            {
                testball++;
            }
            if (checkBox1.Checked == true)
            {
                testball++;
            }
            if (checkBox4.Checked == true)
            {
                testball++;
            }
            if (textBox14.Text == "tkinter")
            {
                testball++;
            }
            if (textBox13.Text == "event")
            {
                testball++;
            }
            if (textBox12.Text == "event")
            {
                testball++;
            }
            if (textBox6.Text == "event")
            {
                testball++;
            }
            if (textBox7.Text == "event")
            {
                testball++;
            }
            if (textBox8.Text == "Button-1")
            {
                testball++;
            }
            if (textBox9.Text == "Button-3")
            {
                testball++;
            }
            if (textBox10.Text == "Motion")
            {
                testball++;
            }

            if (testball >= maxtestball * 0.9)
            {
                testmark = 5;
            }
            if (testball < maxtestball * 0.9 && testball >= maxtestball * 0.75)
            {
                testmark = 4;
            }
            if (testball < maxtestball * 0.75 && testball >= maxtestball * 0.5)
            {
                testmark = 3;
            }
            if (testball < maxtestball * 0.5)
            {
                testmark = 2;
            }

            label14.Text = Convert.ToString(testmark);
            button8.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ExampleForm exampleform = new ExampleForm();
            if (exampleform.ShowDialog() != DialogResult.OK)
            {
                return;
            }
        }
    }
}
