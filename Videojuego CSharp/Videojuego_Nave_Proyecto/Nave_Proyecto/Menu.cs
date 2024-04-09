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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Menu main = new Menu();
            main.StartPosition = FormStartPosition.CenterParent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\ResourcesVS\RecursosU3\Audio\sound4.wav");
            player.Play();
            LVL_ONE lvl1 = new LVL_ONE();
            lvl1.StartPosition = FormStartPosition.CenterParent;
            lvl1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\ResourcesVS\RecursosU3\Audio\sound4.wav");
            player.Play();
            LVL_TWO lvl2 = new LVL_TWO();
            lvl2.StartPosition = FormStartPosition.CenterParent;
            lvl2.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\ResourcesVS\RecursosU3\Audio\sound3.wav");
            player.Play();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\ResourcesVS\RecursosU3\Audio\sound3.wav");
            player.Play();
            MessageBox.Show("No hay registros");

        }
    }
}
