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
    public partial class ExampleForm : Form
    {
        public ExampleForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Example1Form example1 = new Example1Form();
            if (example1.ShowDialog() != DialogResult.OK)
                return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Example2Form example2 = new Example2Form();
            if (example2.ShowDialog() != DialogResult.OK)
                return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Example3Form example3 = new Example3Form();
            if (example3.ShowDialog() != DialogResult.OK)
                return;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Example4Form example4 = new Example4Form();
            if (example4.ShowDialog() != DialogResult.OK)
                return;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
            Menu2Form menu2form = new Menu2Form();
            menu2form.Visible = true;
        }
    }
}
