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
    public partial class GraphIntForm : Form
    {
        double testball = 0;
        double maxtestball = 6;
        int testmark = 0;

        public GraphIntForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Menu2Form menu2form = new Menu2Form();
            menu2form.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PackForm packform = new PackForm();
            packform.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "tkinter")
            {
                testball++;
            }

            if (checkBox1.Checked == true)
            {
                testball++;
            }
            if (checkBox3.Checked == true)
            {
                testball++;
            }

            if (textBox6.Text == "tkinter")
            {
                testball++;
            }
            if (textBox5.Text == "Button")
            {
                testball++;
            }
            if (textBox4.Text == "mainloop")
            {
                testball++;
            }

            if (testball >= maxtestball * 0.9)
            {
                testmark = 5;
            }
            if (testball < maxtestball * 0.9 && testball >= maxtestball * 0.7)
            {
                testmark = 4;
            }
            if (testball < maxtestball * 0.7 && testball >= maxtestball * 0.5)
            {
                testmark = 3;
            }
            if (testball < maxtestball * 0.5)
            {
                testmark = 2;
            }

            label6.Text = Convert.ToString(testmark);

            button3.Visible = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            VidgetForm vidgetform = new VidgetForm();
            if (vidgetform.ShowDialog() != DialogResult.OK)
                return;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Турбо.Form5();
            if (form5.ShowDialog() != DialogResult.OK)
                return;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form17 form17 = new Form17();
            if (form17.ShowDialog() != DialogResult.OK)
                return;
        }
    }
}
