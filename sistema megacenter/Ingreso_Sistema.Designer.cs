namespace sistema_megacenter
{
    partial class Ingreso_Sistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingreso_Sistema));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.BtAceptar = new System.Windows.Forms.Button();
            this.BtVolver = new System.Windows.Forms.Button();
            this.txtclaveingreso = new System.Windows.Forms.TextBox();
            this.txtrutingreso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.BtAceptar);
            this.groupBox1.Controls.Add(this.BtVolver);
            this.groupBox1.Controls.Add(this.txtclaveingreso);
            this.groupBox1.Controls.Add(this.txtrutingreso);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(127, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 324);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inicio Sesión";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.ControlDarkDark;
            this.linkLabel1.Location = new System.Drawing.Point(209, 221);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(189, 17);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Has olvidado tu contraseña?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // BtAceptar
            // 
            this.BtAceptar.BackColor = System.Drawing.Color.Black;
            this.BtAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtAceptar.Location = new System.Drawing.Point(327, 253);
            this.BtAceptar.Name = "BtAceptar";
            this.BtAceptar.Size = new System.Drawing.Size(124, 36);
            this.BtAceptar.TabIndex = 7;
            this.BtAceptar.Text = "Aceptar";
            this.BtAceptar.UseVisualStyleBackColor = false;
            this.BtAceptar.Click += new System.EventHandler(this.BtAceptar_Click);
            // 
            // BtVolver
            // 
            this.BtVolver.BackColor = System.Drawing.Color.Black;
            this.BtVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtVolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtVolver.Location = new System.Drawing.Point(187, 253);
            this.BtVolver.Name = "BtVolver";
            this.BtVolver.Size = new System.Drawing.Size(124, 36);
            this.BtVolver.TabIndex = 6;
            this.BtVolver.Text = "Volver";
            this.BtVolver.UseVisualStyleBackColor = false;
            this.BtVolver.Click += new System.EventHandler(this.BtVolver_Click);
            // 
            // txtclaveingreso
            // 
            this.txtclaveingreso.Location = new System.Drawing.Point(187, 185);
            this.txtclaveingreso.MaxLength = 20;
            this.txtclaveingreso.Name = "txtclaveingreso";
            this.txtclaveingreso.PasswordChar = '*';
            this.txtclaveingreso.ShortcutsEnabled = false;
            this.txtclaveingreso.Size = new System.Drawing.Size(247, 33);
            this.txtclaveingreso.TabIndex = 5;
            this.txtclaveingreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtclaveingreso_KeyPress);
            // 
            // txtrutingreso
            // 
            this.txtrutingreso.Location = new System.Drawing.Point(187, 104);
            this.txtrutingreso.MaxLength = 10;
            this.txtrutingreso.Name = "txtrutingreso";
            this.txtrutingreso.ShortcutsEnabled = false;
            this.txtrutingreso.Size = new System.Drawing.Size(247, 33);
            this.txtrutingreso.TabIndex = 3;
           // this.txtrutingreso.TextChanged += new System.EventHandler(this.txtrutingreso_TextChanged);
            this.txtrutingreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrutingreso_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rut:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 134);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Ingreso_Sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(726, 397);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ingreso_Sistema";
            this.Text = "Ingreso_Sistema";
            this.Load += new System.EventHandler(this.Ingreso_Sistema_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtAceptar;
        private System.Windows.Forms.Button BtVolver;
        private System.Windows.Forms.TextBox txtclaveingreso;
        private System.Windows.Forms.TextBox txtrutingreso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}