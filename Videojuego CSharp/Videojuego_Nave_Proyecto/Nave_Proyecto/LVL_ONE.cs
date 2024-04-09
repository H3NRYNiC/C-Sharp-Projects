using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nave_Proyecto
{
    public partial class LVL_ONE : Form
    {
        private bool btnDown;
        private int offsetX;
        private int offsetY;
        bool mov;
        public int seconds = 60;
        public int points = 0;

        public LVL_ONE()
        {
            InitializeComponent();
            Thread hilo1 = new Thread(metodo_AsteroideR);
            hilo1.Start();
            Thread hilo2 = new Thread(metodo_AsteroideR1);
            hilo2.Start();
            Thread hilo3 = new Thread(metodo_AsteroideR2);
            hilo3.Start();
            DoubleBuffered = true;
            mov = true;
        }

        //MOVIMIENTO NAVE
        private void pxNave_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // el boton izquierdo esta pulsado
                btnDown = true;
                offsetX = e.X;
                offsetY = e.Y;
            }
        }

        private void pxNave_MouseMove(object sender, MouseEventArgs e)
        {
            if (btnDown)
            {
                // mover el pictureBox con el raton               
                pxNave.Left += e.X - offsetX;
                pxNave.Top += e.Y - offsetY;
            }
        }

        private void pxNave_MouseUp(object sender, MouseEventArgs e)
        {
            // el boton izquierdo se libera
            if (e.Button == MouseButtons.Left)
            {
                btnDown = false;
            }
        }

        private void LVL_ONE_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    if (mov)
                    {
                        Thread hilo = new Thread(player_Dispara);
                        hilo.Start();
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\ResourcesVS\RecursosU3\Audio\sound1.wav");
                        player.Play();
                    }
                    break;
            }
        }
        //DELEGADOS INICIALIZADOS AQUI
        private delegate void PlayerDisparar(Control c, int x, int y, bool b);
        private delegate void asteroidesR(PictureBox p, int x, int y, bool b);
        private delegate void asteroideR1(PictureBox p, int x, int y, bool b);
        private delegate void asteroideR2(PictureBox p, int x, int y, bool b);


        //METODOS DELEGADOS

        private void delegado_Disparo(Control c, int x, int y, bool b)
        {
            if (InvokeRequired)
            {
                PlayerDisparar pd = new PlayerDisparar(delegado_Disparo);
                object[] parametros = new object[] { c, x, y, b };
                Invoke(pd, parametros);
            }
            else
            {
                if (b)
                    this.Controls.Add(c);
                c.Location = new Point(x, y);
                if (y <= 0)
                    c.Dispose();
            }
        }
        private void delegado_asteroide0(PictureBox p, int x, int y, bool b)
        {
            if (InvokeRequired)
            {
                asteroidesR asteroide = new asteroidesR(delegado_asteroide0);
                object[] parametros = new object[] { p, x, y, b };
                Invoke(asteroide, parametros);
            }
            else
            {
                p.Location = new Point(x, y);
                if (b == true)
                {
                    Controls.Add(p);
                }
                if (x <= 0)
                {
                    points = points += 1;
                    lblPuntos.Text = "Puntuacion: " + points.ToString();
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\ResourcesVS\RecursosU3\Audio\sound2.wav");
                    player.Play();
                    p.Dispose();
                }
            }
        }
        private void delegado_asteroide1(PictureBox p, int x, int y, bool b)
        {
            if (InvokeRequired)
            {
                asteroideR1 asteroide = new asteroideR1(delegado_asteroide1);
                object[] parametros = new object[] { p, x, y, b };
                Invoke(asteroide, parametros);
            }
            else
            {
                p.Location = new Point(x, y);
                if (b == true)
                {
                    Controls.Add(p);
                }
                if (x <= 0)
                {
                    points = points += 1;
                    lblPuntos.Text = "Puntuacion: " + points.ToString();
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\ResourcesVS\RecursosU3\Audio\sound2.wav");
                    player.Play();
                    p.Dispose();
                }
            }
        }
        private void delegado_asteroide2(PictureBox p, int x, int y, bool b)
        {
            if (InvokeRequired)
            {
                asteroideR2 asteroide = new asteroideR2(delegado_asteroide2);
                object[] parametros = new object[] { p, x, y, b };
                Invoke(asteroide, parametros);
            }
            else
            {
                p.Location = new Point(x, y);
                if (b == true)
                {
                    Controls.Add(p);
                }
                if (x <= 0)
                {
                    points = points += 1;
                    lblPuntos.Text = "Puntuacion: " + points.ToString();
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\ResourcesVS\RecursosU3\Audio\sound2.wav");
                    player.Play();
                    p.Dispose();
                }
            }
        }
        //METODOS ACCIONES
        private void player_Dispara()
        {
            PictureBox p = new PictureBox();
            p.Image = Image.FromFile(@"C:\ResourcesVS\RecursosU3\misil.png");
            p.Size = new Size(30, 30);
            p.SizeMode = PictureBoxSizeMode.Zoom;
            int xn = pxNave.Location.X;
            int yn = pxNave.Location.Y;
            int media = yn + (pxNave.Height / 2);
            delegado_Disparo(p, xn, media, true);
            while (p.Location.Y >= 0)
            {

                delegado_Disparo(p, p.Location.X + 20, media, false);
                Thread.Sleep(10);
            }
        }
        private void metodo_AsteroideR()
        {
            int velociodad = 0;
            Random r = new Random();
            while (mov)
            {
                int y = r.Next(0, this.Height); // esto es para saber el ancho del formulario
                int x = this.Width;
                int inicio = (int)(y / 2);
                PictureBox p = new PictureBox();
                p.Image = Image.FromFile(@"C:\ResourcesVS\RecursosU3\asteroide1.png");
                p.Size = new Size(130, 130);
                p.SizeMode = PictureBoxSizeMode.Zoom;
                delegado_asteroide0(p, x, inicio, true);
                while (p.Location.Y >= 0 && p.Location.X >= 0)
                {
                    if (p.Bounds.IntersectsWith(pxNave.Bounds))
                    {
                        var actionPB = new Action(() =>
                        {

                            if (pbNave.Value > 0)
                            {
                                this.pbNave.Value -= 10;
                                p.Dispose();
                            }
                            if (pbNave.Value == 0)
                            {
                                pxNave.Location = new Point(-100, -100);
                                this.Controls.Remove(pxNave);
                                this.Hide();
                                YouLost yl = new YouLost();
                                yl.StartPosition = FormStartPosition.CenterParent;
                                yl.ShowDialog();
                            }
                        });
                        pxNave.Invoke(actionPB);
                        break;
                    }
                    delegado_asteroide0(p, p.Location.X - 2, p.Location.Y, false);
                    velociodad = r.Next(0, 20);
                    Thread.Sleep(velociodad);
                }
            }
        }
        private void metodo_AsteroideR1()
        {
            int velociodad = 0;
            Random r = new Random();
            while (mov)
            {
                int y = r.Next(0, this.Height); // esto es para saber el ancho del formulario
                int x = this.Width;
                int inicio = (int)(y / 2);
                PictureBox p = new PictureBox();
                p.Image = Image.FromFile(@"C:\ResourcesVS\RecursosU3\asteroide2.png");
                p.Size = new Size(150, 150);
                p.SizeMode = PictureBoxSizeMode.Zoom;
                delegado_asteroide1(p, x, inicio, true);
                while (p.Location.Y >= 0 && p.Location.X >= 0)
                {
                    if (p.Bounds.IntersectsWith(pxNave.Bounds))
                    {
                        var actionPB = new Action(() =>
                        {

                            if (pbNave.Value > 0)
                            {
                                this.pbNave.Value -= 10;
                                p.Dispose();
                            }
                            if (pbNave.Value == 0)
                            {
                                pxNave.Location = new Point(-100, -100);
                                this.Controls.Remove(pxNave);
                                this.Hide();
                                YouLost yl = new YouLost();
                                yl.StartPosition = FormStartPosition.CenterParent;
                                yl.ShowDialog();
                            }
                        });
                        pxNave.Invoke(actionPB);
                        break;
                    }
                    delegado_asteroide1(p, p.Location.X - 5, p.Location.Y, false);
                    velociodad = r.Next(0, 20);
                    Thread.Sleep(velociodad);
                }
            }
        }
        private void metodo_AsteroideR2()
        {
            int velociodad = 0;
            Random r = new Random();
            while (mov)
            {
                int y = r.Next(0, this.Height); // esto es para saber el ancho del formulario
                int x = this.Width;
                int inicio = (int)(y / 2);
                PictureBox p = new PictureBox();
                p.Image = Image.FromFile(@"C:\ResourcesVS\RecursosU3\asteroide3.png");
                p.Size = new Size(120, 120);
                p.SizeMode = PictureBoxSizeMode.Zoom;
                delegado_asteroide2(p, x, inicio, true);
                while (p.Location.Y >= 0 && p.Location.X >= 0)
                {
                    if (p.Bounds.IntersectsWith(pxNave.Bounds))
                    {
                        var actionPB = new Action(() =>
                        {

                            if (pbNave.Value > 0)
                            {
                                this.pbNave.Value -= 10;
                                p.Dispose();
                            }
                            if (pbNave.Value == 0)
                            {
                                pxNave.Location = new Point(-100, -100);
                                this.Controls.Remove(pxNave);
                                this.Hide();
                                YouLost yl = new YouLost();
                                yl.StartPosition = FormStartPosition.CenterParent;
                                yl.ShowDialog();
                            }
                        });
                        pxNave.Invoke(actionPB);
                        break;
                    }
                    delegado_asteroide2(p, p.Location.X - 4, p.Location.Y, false);
                    velociodad = r.Next(0, 20);
                    Thread.Sleep(velociodad);
                }
            }
        }

        //TIMER
        private void tiempoForm_Tick(object sender, EventArgs e)
        {
            if (seconds > 0)
            {
                seconds = seconds - 1;
                lblTiempo.Text = seconds.ToString();
                if (seconds == 15)
                {
                    lblTiempo.ForeColor = Color.Red;
                }
            }
            else if (seconds == 0)
            {
                pxNave.Dispose();
                this.Hide();
            }
        }
        //CERRAR VENTANA
        private void LVL_ONE_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}