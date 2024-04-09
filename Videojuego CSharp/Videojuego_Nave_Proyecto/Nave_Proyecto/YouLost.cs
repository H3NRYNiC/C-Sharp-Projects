using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nave_Proyecto
{
    public partial class YouLost : Form
    {
        public YouLost()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.StartPosition = FormStartPosition.CenterParent;
            menu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
