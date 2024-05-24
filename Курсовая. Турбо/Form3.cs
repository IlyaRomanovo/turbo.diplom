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
    public partial class VidgetForm : Form
    {
        double testball = 0;
        double maxtestball = 12;
        int testmark = 0;

        public VidgetForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form11 form11 = new Form11();
            if (form11.ShowDialog() != DialogResult.OK)
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Menu2Form menu2form = new Menu2Form();
            menu2form.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            if (form12.ShowDialog() != DialogResult.OK)
            {
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            if (form13.ShowDialog() != DialogResult.OK)
            {
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Турбо.Form14();
            if (form14.ShowDialog() != DialogResult.OK)
            {
                return;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15();
            if (form15.ShowDialog() != DialogResult.OK)
            {
                return;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Турбо.Form15();
            if (form15.ShowDialog() != DialogResult.OK)
            {
                return;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox10.Text == "configure()")
            {
                testball++;
            }
            if (checkBox1.Checked == true)
            {
                testball++;
            }
            if (checkBox5.Checked == true)
            {
                testball++;
            }
            if (radioButton2.Checked == true)
            {
                testball++;
            }
            if (textBox11.Text == "tkinter")
            {
                testball++;
            }
            if (textBox12.Text == "def")
            {
                testball++;
            }
            if (textBox13.Text == "configure")
            {
                testball++;
            }
            if (textBox14.Text == "Entry")
            {
                testball++;
            }
            if (textBox15.Text == "grid")
            {
                testball++;
            }
            if (textBox16.Text == "Button")
            {
                testball++;
            }
            if (textBox17.Text == "command")
            {
                testball++;
            }
            if (textBox18.Text == "mainloop")
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
            DevelopForm developform = new DevelopForm();
            if (developform.ShowDialog() != DialogResult.OK)
            {
                return;
            }
        }
    }
}
