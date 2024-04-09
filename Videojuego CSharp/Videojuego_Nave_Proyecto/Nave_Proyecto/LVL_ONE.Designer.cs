namespace Nave_Proyecto
{
    partial class LVL_ONE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pxNave = new System.Windows.Forms.PictureBox();
            this.tiempoForm = new System.Windows.Forms.Timer(this.components);
            this.lblPuntos = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.pbNave = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pxNave)).BeginInit();
            this.SuspendLayout();
            // 
            // pxNave
            // 
            this.pxNave.BackColor = System.Drawing.Color.Transparent;
            this.pxNave.Image = global::Nave_Proyecto.Properties.Resources.navw;
            this.pxNave.Location = new System.Drawing.Point(25, 270);
            this.pxNave.Name = "pxNave";
            this.pxNave.Size = new System.Drawing.Size(125, 62);
            this.pxNave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxNave.TabIndex = 0;
            this.pxNave.TabStop = false;
            this.pxNave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pxNave_MouseDown);
            this.pxNave.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pxNave_MouseMove);
            this.pxNave.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pxNave_MouseUp);
            // 
            // tiempoForm
            // 
            this.tiempoForm.Enabled = true;
            this.tiempoForm.Interval = 1000;
            this.tiempoForm.Tick += new System.EventHandler(this.tiempoForm_Tick);
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPuntos.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblPuntos.Location = new System.Drawing.Point(12, 9);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(129, 34);
            this.lblPuntos.TabIndex = 1;
            this.lblPuntos.Text = "Puntuacion: ";
            // 
            // lblTiempo
            // 
            this.lblTiempo.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTiempo.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblTiempo.Location = new System.Drawing.Point(1185, 9);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(65, 43);
            this.lblTiempo.TabIndex = 2;
            this.lblTiempo.Text = "--";
            // 
            // pbNave
            // 
            this.pbNave.Location = new System.Drawing.Point(12, 651);
            this.pbNave.Name = "pbNave";
            this.pbNave.Size = new System.Drawing.Size(1238, 10);
            this.pbNave.TabIndex = 3;
            this.pbNave.Value = 100;
            // 
            // LVL_ONE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.pbNave);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.pxNave);
            this.Name = "LVL_ONE";
            this.Text = "LVL_ONE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LVL_ONE_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LVL_ONE_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pxNave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pxNave;
        private System.Windows.Forms.Timer tiempoForm;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.ProgressBar pbNave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.PictureBox pictureBox23;
    }
}