namespace sistema_megacenter
{
    partial class Menu_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Principal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fotoinicioadministrador = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btciudad = new System.Windows.Forms.Button();
            this.btcategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoinicioadministrador)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 110);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(713, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nombre Administrador:";
            // 
            // fotoinicioadministrador
            // 
            this.fotoinicioadministrador.Location = new System.Drawing.Point(937, 25);
            this.fotoinicioadministrador.Name = "fotoinicioadministrador";
            this.fotoinicioadministrador.Size = new System.Drawing.Size(133, 111);
            this.fotoinicioadministrador.TabIndex = 3;
            this.fotoinicioadministrador.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(780, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha";
            // 
            // btciudad
            // 
            this.btciudad.BackColor = System.Drawing.Color.Transparent;
            this.btciudad.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btciudad.FlatAppearance.BorderSize = 0;
            this.btciudad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btciudad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btciudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btciudad.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btciudad.ForeColor = System.Drawing.Color.White;
            this.btciudad.Image = ((System.Drawing.Image)(resources.GetObject("btciudad.Image")));
            this.btciudad.Location = new System.Drawing.Point(59, 158);
            this.btciudad.Name = "btciudad";
            this.btciudad.Size = new System.Drawing.Size(126, 131);
            this.btciudad.TabIndex = 11;
            this.btciudad.Text = "\r\n\rCIUDAD";
            this.btciudad.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btciudad.UseVisualStyleBackColor = false;
            this.btciudad.Click += new System.EventHandler(this.btciudad_Click);
            // 
            // btcategoria
            // 
            this.btcategoria.BackColor = System.Drawing.Color.Transparent;
            this.btcategoria.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btcategoria.FlatAppearance.BorderSize = 0;
            this.btcategoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btcategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btcategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcategoria.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btcategoria.ForeColor = System.Drawing.Color.White;
            this.btcategoria.Image = ((System.Drawing.Image)(resources.GetObject("btcategoria.Image")));
            this.btcategoria.Location = new System.Drawing.Point(59, 317);
            this.btcategoria.Name = "btcategoria";
            this.btcategoria.Size = new System.Drawing.Size(126, 131);
            this.btcategoria.TabIndex = 12;
            this.btcategoria.Text = "\r\n\rCATEGORIA";
            this.btcategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btcategoria.UseVisualStyleBackColor = false;
            this.btcategoria.Click += new System.EventHandler(this.btcategoria_Click);
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1230, 559);
            this.Controls.Add(this.btcategoria);
            this.Controls.Add(this.btciudad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fotoinicioadministrador);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu_Principal";
            this.Text = "Menu_Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoinicioadministrador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox fotoinicioadministrador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btciudad;
        private System.Windows.Forms.Button btcategoria;
    }
}