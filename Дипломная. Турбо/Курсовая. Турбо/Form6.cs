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
    public partial class Menu2Form : Form
    {
        public Menu2Form()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
            MenuForm menuform = new Турбо.MenuForm();
            menuform.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GraphIntForm graph = new GraphIntForm();
            if (graph.ShowDialog() != DialogResult.OK)
                return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            VidgetForm vidgetform = new VidgetForm();
            if (vidgetform.ShowDialog() != DialogResult.OK)
            {
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DevelopForm developform = new DevelopForm();
            if (developform.ShowDialog() != DialogResult.OK)
            {
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ExampleForm exampleform = new ExampleForm();
            if (exampleform.ShowDialog() != DialogResult.OK)
            {
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ExamForm examform = new ExamForm();
            if (examform.ShowDialog() != DialogResult.OK)
            {
                return;
            }
        }
    }
}
