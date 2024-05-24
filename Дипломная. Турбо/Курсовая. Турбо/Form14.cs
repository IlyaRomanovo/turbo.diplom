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
    public partial class Form14 : Form
    {
        int count = 0;

        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            button1.Text = "Count=" + count;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            VidgetForm vidgetform = new VidgetForm();
            if (vidgetform.ShowDialog() != DialogResult.OK)
            {
                return;
            }
        }
    }
}
