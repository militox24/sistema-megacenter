namespace sistema_megacenter
{
    partial class Mantenedor_Buscar_Correo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenedor_Buscar_Correo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbtipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Grillaconsultacorreo2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtAceptar = new System.Windows.Forms.Button();
            this.grillaconsultadatoscorreo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btbuscarcorreo = new System.Windows.Forms.Button();
            this.txtconsultacorreo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbcargaperfiles = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grillaconsultacorreo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaconsultadatoscorreo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbtipo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Grillaconsultacorreo2);
            this.groupBox1.Controls.Add(this.BtAceptar);
            this.groupBox1.Controls.Add(this.grillaconsultadatoscorreo);
            this.groupBox1.Controls.Add(this.btbuscarcorreo);
            this.groupBox1.Controls.Add(this.txtconsultacorreo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbcargaperfiles);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(26, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 383);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar Correos";
            // 
            // cbtipo
            // 
            this.cbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtipo.FormattingEnabled = true;
            this.cbtipo.Items.AddRange(new object[] {
            "Seleccione",
            "Administrador",
            "Vendedor",
            "Proveedor"});
            this.cbtipo.Location = new System.Drawing.Point(423, 73);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(184, 28);
            this.cbtipo.TabIndex = 33;
            this.cbtipo.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(315, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Tipo Usuario:";
            this.label3.Visible = false;
            // 
            // Grillaconsultacorreo2
            // 
            this.Grillaconsultacorreo2.AllowUserToAddRows = false;
            this.Grillaconsultacorreo2.AllowUserToDeleteRows = false;
            this.Grillaconsultacorreo2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grillaconsultacorreo2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            this.Grillaconsultacorreo2.Location = new System.Drawing.Point(21, 115);
            this.Grillaconsultacorreo2.Name = "Grillaconsultacorreo2";
            this.Grillaconsultacorreo2.Size = new System.Drawing.Size(691, 192);
            this.Grillaconsultacorreo2.TabIndex = 31;
            this.Grillaconsultacorreo2.Visible = false;
            this.Grillaconsultacorreo2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grillaconsultacorreo2_CellClick);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.FalseValue = "false";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Seleccione";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.TrueValue = "true";
            // 
            // BtAceptar
            // 
            this.BtAceptar.BackColor = System.Drawing.Color.Black;
            this.BtAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtAceptar.Image = ((System.Drawing.Image)(resources.GetObject("BtAceptar.Image")));
            this.BtAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtAceptar.Location = new System.Drawing.Point(281, 313);
            this.BtAceptar.Name = "BtAceptar";
            this.BtAceptar.Size = new System.Drawing.Size(201, 36);
            this.BtAceptar.TabIndex = 30;
            this.BtAceptar.Text = "Volver a Correos";
            this.BtAceptar.UseVisualStyleBackColor = false;
            this.BtAceptar.Click += new System.EventHandler(this.BtAceptar_Click);
            // 
            // grillaconsultadatoscorreo
            // 
            this.grillaconsultadatoscorreo.AllowUserToAddRows = false;
            this.grillaconsultadatoscorreo.AllowUserToDeleteRows = false;
            this.grillaconsultadatoscorreo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaconsultadatoscorreo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.grillaconsultadatoscorreo.Location = new System.Drawing.Point(21, 115);
            this.grillaconsultadatoscorreo.Name = "grillaconsultadatoscorreo";
            this.grillaconsultadatoscorreo.Size = new System.Drawing.Size(691, 192);
            this.grillaconsultadatoscorreo.TabIndex = 29;
            this.grillaconsultadatoscorreo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaconsultadatoscorreo_CellClick);
            // 
            // Column1
            // 
            this.Column1.FalseValue = "false";
            this.Column1.HeaderText = "Seleccione";
            this.Column1.Name = "Column1";
            this.Column1.TrueValue = "true";
            // 
            // btbuscarcorreo
            // 
            this.btbuscarcorreo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btbuscarcorreo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btbuscarcorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbuscarcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbuscarcorreo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btbuscarcorreo.Image = ((System.Drawing.Image)(resources.GetObject("btbuscarcorreo.Image")));
            this.btbuscarcorreo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbuscarcorreo.Location = new System.Drawing.Point(613, 73);
            this.btbuscarcorreo.Name = "btbuscarcorreo";
            this.btbuscarcorreo.Size = new System.Drawing.Size(99, 28);
            this.btbuscarcorreo.TabIndex = 28;
            this.btbuscarcorreo.Text = "Buscar";
            this.btbuscarcorreo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btbuscarcorreo.UseVisualStyleBackColor = false;
            this.btbuscarcorreo.Visible = false;
            this.btbuscarcorreo.Click += new System.EventHandler(this.btbuscarcorreo_Click);
            // 
            // txtconsultacorreo
            // 
            this.txtconsultacorreo.Location = new System.Drawing.Point(92, 74);
            this.txtconsultacorreo.Name = "txtconsultacorreo";
            this.txtconsultacorreo.ShortcutsEnabled = false;
            this.txtconsultacorreo.Size = new System.Drawing.Size(217, 26);
            this.txtconsultacorreo.TabIndex = 3;
            this.txtconsultacorreo.Visible = false;
            this.txtconsultacorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtconsultacorreo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione Filtro:";
            // 
            // cbcargaperfiles
            // 
            this.cbcargaperfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcargaperfiles.FormattingEnabled = true;
            this.cbcargaperfiles.Items.AddRange(new object[] {
            "Proveedor",
            "Administrador",
            "Vendedor",
            "Otro Filtro Busqueda"});
            this.cbcargaperfiles.Location = new System.Drawing.Point(149, 36);
            this.cbcargaperfiles.Name = "cbcargaperfiles";
            this.cbcargaperfiles.Size = new System.Drawing.Size(208, 28);
            this.cbcargaperfiles.TabIndex = 0;
            this.cbcargaperfiles.SelectedValueChanged += new System.EventHandler(this.cbcargaperfiles_SelectedValueChanged);
            // 
            // Mantenedor_Buscar_Correo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(793, 424);
            this.Controls.Add(this.groupBox1);
            this.Name = "Mantenedor_Buscar_Correo";
            this.Text = "Mantenedor_Buscar_Correo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grillaconsultacorreo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaconsultadatoscorreo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtconsultacorreo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbcargaperfiles;
        private System.Windows.Forms.DataGridView grillaconsultadatoscorreo;
        private System.Windows.Forms.Button btbuscarcorreo;
        private System.Windows.Forms.Button BtAceptar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridView Grillaconsultacorreo2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.ComboBox cbtipo;
        private System.Windows.Forms.Label label3;
    }
}