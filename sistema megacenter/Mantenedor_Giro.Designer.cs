namespace sistema_megacenter
{
    partial class Mantenedor_Giro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenedor_Giro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btcargaagregagiro = new System.Windows.Forms.Button();
            this.btcargaeliminagiro = new System.Windows.Forms.Button();
            this.gbagregagiro = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtgiroagrega = new System.Windows.Forms.TextBox();
            this.txtdescripciongiro = new System.Windows.Forms.TextBox();
            this.gbeliminagiro = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtgiroeliminar = new System.Windows.Forms.TextBox();
            this.grillagiros = new System.Windows.Forms.DataGridView();
            this.btbuscargiroelim = new System.Windows.Forms.Button();
            this.btelimgiro = new System.Windows.Forms.Button();
            this.btagregargiro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbagregagiro.SuspendLayout();
            this.gbeliminagiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillagiros)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btcargaeliminagiro);
            this.panel1.Controls.Add(this.btcargaagregagiro);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 343);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.gbagregagiro);
            this.panel2.Controls.Add(this.gbeliminagiro);
            this.panel2.Location = new System.Drawing.Point(170, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(578, 343);
            this.panel2.TabIndex = 1;
            // 
            // btcargaagregagiro
            // 
            this.btcargaagregagiro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btcargaagregagiro.BackgroundImage")));
            this.btcargaagregagiro.ForeColor = System.Drawing.SystemColors.Control;
            this.btcargaagregagiro.Location = new System.Drawing.Point(13, 38);
            this.btcargaagregagiro.Name = "btcargaagregagiro";
            this.btcargaagregagiro.Size = new System.Drawing.Size(97, 93);
            this.btcargaagregagiro.TabIndex = 3;
            this.btcargaagregagiro.Text = "Agregar";
            this.btcargaagregagiro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btcargaagregagiro.UseVisualStyleBackColor = true;
            this.btcargaagregagiro.Click += new System.EventHandler(this.btcargaagregagiro_Click);
            // 
            // btcargaeliminagiro
            // 
            this.btcargaeliminagiro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btcargaeliminagiro.BackgroundImage")));
            this.btcargaeliminagiro.ForeColor = System.Drawing.SystemColors.Control;
            this.btcargaeliminagiro.Location = new System.Drawing.Point(13, 188);
            this.btcargaeliminagiro.Name = "btcargaeliminagiro";
            this.btcargaeliminagiro.Size = new System.Drawing.Size(97, 93);
            this.btcargaeliminagiro.TabIndex = 4;
            this.btcargaeliminagiro.Text = "Eliminar";
            this.btcargaeliminagiro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btcargaeliminagiro.UseVisualStyleBackColor = true;
            this.btcargaeliminagiro.Click += new System.EventHandler(this.btcargaeliminagiro_Click);
            // 
            // gbagregagiro
            // 
            this.gbagregagiro.Controls.Add(this.label4);
            this.gbagregagiro.Controls.Add(this.label3);
            this.gbagregagiro.Controls.Add(this.btagregargiro);
            this.gbagregagiro.Controls.Add(this.txtdescripciongiro);
            this.gbagregagiro.Controls.Add(this.txtgiroagrega);
            this.gbagregagiro.Controls.Add(this.label1);
            this.gbagregagiro.Controls.Add(this.label7);
            this.gbagregagiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbagregagiro.ForeColor = System.Drawing.Color.Gold;
            this.gbagregagiro.Location = new System.Drawing.Point(23, 31);
            this.gbagregagiro.Name = "gbagregagiro";
            this.gbagregagiro.Size = new System.Drawing.Size(474, 283);
            this.gbagregagiro.TabIndex = 0;
            this.gbagregagiro.TabStop = false;
            this.gbagregagiro.Text = "Agregar Giro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(17, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Giro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Descripción:";
            // 
            // txtgiroagrega
            // 
            this.txtgiroagrega.Location = new System.Drawing.Point(71, 59);
            this.txtgiroagrega.Name = "txtgiroagrega";
            this.txtgiroagrega.Size = new System.Drawing.Size(281, 26);
            this.txtgiroagrega.TabIndex = 11;
            this.txtgiroagrega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgiroagrega_KeyPress);
            // 
            // txtdescripciongiro
            // 
            this.txtdescripciongiro.Location = new System.Drawing.Point(131, 104);
            this.txtdescripciongiro.Multiline = true;
            this.txtdescripciongiro.Name = "txtdescripciongiro";
            this.txtdescripciongiro.Size = new System.Drawing.Size(251, 100);
            this.txtdescripciongiro.TabIndex = 12;
            this.txtdescripciongiro.TextChanged += new System.EventHandler(this.txtdescripciongiro_TextChanged);
            this.txtdescripciongiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdescripciongiro_KeyPress);
            // 
            // gbeliminagiro
            // 
            this.gbeliminagiro.Controls.Add(this.btelimgiro);
            this.gbeliminagiro.Controls.Add(this.btbuscargiroelim);
            this.gbeliminagiro.Controls.Add(this.grillagiros);
            this.gbeliminagiro.Controls.Add(this.txtgiroeliminar);
            this.gbeliminagiro.Controls.Add(this.label2);
            this.gbeliminagiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbeliminagiro.ForeColor = System.Drawing.Color.Gold;
            this.gbeliminagiro.Location = new System.Drawing.Point(23, 38);
            this.gbeliminagiro.Name = "gbeliminagiro";
            this.gbeliminagiro.Size = new System.Drawing.Size(474, 276);
            this.gbeliminagiro.TabIndex = 13;
            this.gbeliminagiro.TabStop = false;
            this.gbeliminagiro.Text = "Eliminar Giro";
            this.gbeliminagiro.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Giro:";
            // 
            // txtgiroeliminar
            // 
            this.txtgiroeliminar.Location = new System.Drawing.Point(60, 32);
            this.txtgiroeliminar.Name = "txtgiroeliminar";
            this.txtgiroeliminar.Size = new System.Drawing.Size(245, 26);
            this.txtgiroeliminar.TabIndex = 11;
            // 
            // grillagiros
            // 
            this.grillagiros.AllowUserToAddRows = false;
            this.grillagiros.AllowUserToDeleteRows = false;
            this.grillagiros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillagiros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.grillagiros.Location = new System.Drawing.Point(10, 64);
            this.grillagiros.Name = "grillagiros";
            this.grillagiros.Size = new System.Drawing.Size(458, 150);
            this.grillagiros.TabIndex = 12;
            // 
            // btbuscargiroelim
            // 
            this.btbuscargiroelim.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btbuscargiroelim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btbuscargiroelim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbuscargiroelim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbuscargiroelim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btbuscargiroelim.Image = ((System.Drawing.Image)(resources.GetObject("btbuscargiroelim.Image")));
            this.btbuscargiroelim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbuscargiroelim.Location = new System.Drawing.Point(311, 31);
            this.btbuscargiroelim.Name = "btbuscargiroelim";
            this.btbuscargiroelim.Size = new System.Drawing.Size(107, 28);
            this.btbuscargiroelim.TabIndex = 23;
            this.btbuscargiroelim.Text = "Buscar";
            this.btbuscargiroelim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btbuscargiroelim.UseVisualStyleBackColor = false;
            this.btbuscargiroelim.Click += new System.EventHandler(this.btbuscargiroelim_Click);
            // 
            // btelimgiro
            // 
            this.btelimgiro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btelimgiro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btelimgiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btelimgiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btelimgiro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btelimgiro.Image = ((System.Drawing.Image)(resources.GetObject("btelimgiro.Image")));
            this.btelimgiro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btelimgiro.Location = new System.Drawing.Point(274, 220);
            this.btelimgiro.Name = "btelimgiro";
            this.btelimgiro.Size = new System.Drawing.Size(124, 36);
            this.btelimgiro.TabIndex = 27;
            this.btelimgiro.Text = "Eliminar";
            this.btelimgiro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btelimgiro.UseVisualStyleBackColor = false;
            this.btelimgiro.Click += new System.EventHandler(this.btelimgiro_Click);
            // 
            // btagregargiro
            // 
            this.btagregargiro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btagregargiro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btagregargiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btagregargiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btagregargiro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btagregargiro.Image = ((System.Drawing.Image)(resources.GetObject("btagregargiro.Image")));
            this.btagregargiro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btagregargiro.Location = new System.Drawing.Point(311, 220);
            this.btagregargiro.Name = "btagregargiro";
            this.btagregargiro.Size = new System.Drawing.Size(113, 36);
            this.btagregargiro.TabIndex = 27;
            this.btagregargiro.Text = "Agregar";
            this.btagregargiro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btagregargiro.UseVisualStyleBackColor = false;
            this.btagregargiro.Click += new System.EventHandler(this.btagregargiro_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(138, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "N° Letras:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(199, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Letras";
            // 
            // Column1
            // 
            this.Column1.FalseValue = "false";
            this.Column1.HeaderText = "Seleccione";
            this.Column1.Name = "Column1";
            this.Column1.TrueValue = "true";
            // 
            // Mantenedor_Giro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(789, 396);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Mantenedor_Giro";
            this.Text = "Mantenedor_Giro";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gbagregagiro.ResumeLayout(false);
            this.gbagregagiro.PerformLayout();
            this.gbeliminagiro.ResumeLayout(false);
            this.gbeliminagiro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillagiros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btcargaagregagiro;
        private System.Windows.Forms.Button btcargaeliminagiro;
        private System.Windows.Forms.GroupBox gbagregagiro;
        private System.Windows.Forms.TextBox txtdescripciongiro;
        private System.Windows.Forms.TextBox txtgiroagrega;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btagregargiro;
        private System.Windows.Forms.GroupBox gbeliminagiro;
        private System.Windows.Forms.Button btelimgiro;
        private System.Windows.Forms.Button btbuscargiroelim;
        private System.Windows.Forms.DataGridView grillagiros;
        private System.Windows.Forms.TextBox txtgiroeliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
    }
}