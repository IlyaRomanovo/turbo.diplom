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
    public partial class Example4Form : Form
    {
        public Example4Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 1)
            {
                label11.Text = "Умница!";
            }
            else
            {
                label11.Text = "Поучи-ка ещё";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            label11.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            ExampleForm exampleform = new ExampleForm();
            exampleform.Visible = true;
        }
    }
}
