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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Autorisation autoris = new Autorisation();
            if (autoris.ShowDialog() != DialogResult.OK)
                return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Menu2Form menu2form = new Menu2Form();
            if (menu2form.ShowDialog() != DialogResult.Cancel)
                return;
        }
    }
}
