namespace Nave_Proyecto
{
    partial class LVL_TWO
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
            this.pbNave = new System.Windows.Forms.ProgressBar();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.pxNave = new System.Windows.Forms.PictureBox();
            this.timeTwo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pxNave)).BeginInit();
            this.SuspendLayout();
            // 
            // pbNave
            // 
            this.pbNave.Location = new System.Drawing.Point(12, 647);
            this.pbNave.Name = "pbNave";
            this.pbNave.Size = new System.Drawing.Size(1238, 10);
            this.pbNave.TabIndex = 30;
            this.pbNave.Value = 100;
            // 
            // lblTiempo
            // 
            this.lblTiempo.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTiempo.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblTiempo.Location = new System.Drawing.Point(1185, 5);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(65, 43);
            this.lblTiempo.TabIndex = 29;
            this.lblTiempo.Text = "--";
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPuntos.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblPuntos.Location = new System.Drawing.Point(12, 5);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(129, 34);
            this.lblPuntos.TabIndex = 28;
            this.lblPuntos.Text = "Puntuacion: ";
            // 
            // pxNave
            // 
            this.pxNave.BackColor = System.Drawing.Color.Transparent;
            this.pxNave.Image = global::Nave_Proyecto.Properties.Resources.navw;
            this.pxNave.Location = new System.Drawing.Point(12, 271);
            this.pxNave.Name = "pxNave";
            this.pxNave.Size = new System.Drawing.Size(125, 62);
            this.pxNave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pxNave.TabIndex = 27;
            this.pxNave.TabStop = false;
            this.pxNave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pxNave_MouseDown);
            this.pxNave.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pxNave_MouseMove);
            this.pxNave.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pxNave_MouseUp);
            // 
            // timeTwo
            // 
            this.timeTwo.Enabled = true;
            this.timeTwo.Interval = 1000;
            this.timeTwo.Tick += new System.EventHandler(this.timeTwo_Tick);
            // 
            // LVL_TWO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.pbNave);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.pxNave);
            this.Name = "LVL_TWO";
            this.Text = "LVL_TWO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LVL_TWO_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LVL_TWO_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pxNave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbNave;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.PictureBox pxNave;
        private System.Windows.Forms.Timer timeTwo;
    }
}