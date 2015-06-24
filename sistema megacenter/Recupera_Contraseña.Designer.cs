namespace sistema_megacenter
{
    partial class Recupera_Contraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recupera_Contraseña));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btsalir = new System.Windows.Forms.Button();
            this.btconsultarutrecupera = new System.Windows.Forms.Button();
            this.txtrutrecupera = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btsalir);
            this.groupBox1.Controls.Add(this.btconsultarutrecupera);
            this.groupBox1.Controls.Add(this.txtrutrecupera);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(39, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "¿No puedes acceder a tu cuenta?";
            // 
            // Btsalir
            // 
            this.Btsalir.BackColor = System.Drawing.SystemColors.ControlText;
            this.Btsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btsalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btsalir.Image = ((System.Drawing.Image)(resources.GetObject("Btsalir.Image")));
            this.Btsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btsalir.Location = new System.Drawing.Point(139, 118);
            this.Btsalir.Name = "Btsalir";
            this.Btsalir.Size = new System.Drawing.Size(166, 36);
            this.Btsalir.TabIndex = 3;
            this.Btsalir.Text = "Salir";
            this.Btsalir.UseVisualStyleBackColor = false;
            this.Btsalir.Click += new System.EventHandler(this.Btsalir_Click);
            // 
            // btconsultarutrecupera
            // 
            this.btconsultarutrecupera.BackColor = System.Drawing.SystemColors.ControlText;
            this.btconsultarutrecupera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btconsultarutrecupera.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btconsultarutrecupera.Image = ((System.Drawing.Image)(resources.GetObject("btconsultarutrecupera.Image")));
            this.btconsultarutrecupera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btconsultarutrecupera.Location = new System.Drawing.Point(322, 49);
            this.btconsultarutrecupera.Name = "btconsultarutrecupera";
            this.btconsultarutrecupera.Size = new System.Drawing.Size(145, 28);
            this.btconsultarutrecupera.TabIndex = 2;
            this.btconsultarutrecupera.Text = "Consultar";
            this.btconsultarutrecupera.UseVisualStyleBackColor = false;
            this.btconsultarutrecupera.Click += new System.EventHandler(this.btconsultarutrecupera_Click);
            // 
            // txtrutrecupera
            // 
            this.txtrutrecupera.Location = new System.Drawing.Point(64, 48);
            this.txtrutrecupera.MaxLength = 10;
            this.txtrutrecupera.Name = "txtrutrecupera";
            this.txtrutrecupera.ShortcutsEnabled = false;
            this.txtrutrecupera.Size = new System.Drawing.Size(241, 24);
            this.txtrutrecupera.TabIndex = 1;
            this.txtrutrecupera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrutrecupera_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut:";
            // 
            // Recupera_Contraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(614, 282);
            this.Controls.Add(this.groupBox1);
            this.Name = "Recupera_Contraseña";
            this.Text = "Recupera_Contraseña";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btconsultarutrecupera;
        private System.Windows.Forms.TextBox txtrutrecupera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btsalir;
    }
}